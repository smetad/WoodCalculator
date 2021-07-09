
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using woodcalc_00._model;
using woodcalc_00._service;
using woodcalc_00.Service.DataServices;

namespace woodcalc_00._viewmodel
{
    public class ExportViewModel : BaseViewModel
    {
        private string typeOfCalculation;
        private ObservableCollection<Log> dataList;
        private readonly List<Log> rawData;
        private string path;
        private ICommand saveFileCommand;

        public ExportViewModel()
        {
            rawData = new List<Log>(new LogDataService(new DataService<Log>()).GetLogs());
            foreach (Log item in rawData)
            {
                if (item.Quality == null)
                {
                    item.Quality = new Model.Quality() { QualityClass = string.Empty };
                }
                if (item.Tree == null)
                {
                    item.Tree = new Tree() { TypeOfTree = string.Empty };
                }
            }
            CalculationMethods = (from item in rawData select item.Calculation.TypeOfCalculation).Distinct().ToList();
            AllDataActive = true;
        }
        public ICommand SaveFileCommand => saveFileCommand ??= new RelayCommand(SaveFile, CanSave);
        public string TypeOfCalculation
        {
            get => typeOfCalculation;

            set
            {
                if (typeOfCalculation != value)
                {
                    typeOfCalculation = value;
                    OnPropertyChanged();
                    UpdateData(typeOfCalculation);
                }
            }
        }
        public ObservableCollection<Log> DataList
        {
            get => dataList;
            set
            {
                if (dataList != value)
                {
                    dataList = value;
                    OnPropertyChanged();
                }
            }
        }
        public List<int> IndexList { get; }
        private bool allData;

        public bool AllDataActive
        {
            get { return allData; }
            set 
            { 
                allData = value;
                OnPropertyChanged();
                UpdateData(string.Empty);
            }
        }

        public string Format { get; set; }
        public string Path
        {
            get { return path; }
            set 
            {
                if (path != value)
                {
                    path = value;
                    OnPropertyChanged();
                }
            }
        }
        private void UpdateData(string typeOfCalc)
        {
            if (string.IsNullOrEmpty(typeOfCalc) && AllDataActive)
            {
                DataList = new ObservableCollection<Log>(UpdateIndex(rawData));
            }
            else if (!string.IsNullOrEmpty(typeOfCalc))
            {
                DataList = new ObservableCollection<Log>(UpdateIndex(rawData.FindAll(x => x.Calculation.TypeOfCalculation == typeOfCalc)));
            }
        }
        private List<Log> UpdateIndex(List<Log> list)
        {
            int index = 1;
            foreach (var item in list)
            {
                item.Id = index++;
            }
            return list;
        }

        private void SaveFile()
        {
            switch (Format[(Format.IndexOf(' ') + 1)..])
            {
                case "xlsx": new DataExport(dataList.ToList()).CreateExcel(Path); break;
                case "csv": new DataExport(dataList.ToList()).CreateCSV(Path); break;
                default:
                    break;
            }
        }
        private bool CanSave()
        {
            return !string.IsNullOrEmpty(Format) && Directory.Exists(Path);
        }
    }
}

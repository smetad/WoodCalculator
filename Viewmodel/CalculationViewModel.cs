using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using woodcalc_00._model;
using woodcalc_00.Properties;
using woodcalc_00._service;
using woodcalc_00.Service.DataServices;
using woodcalc_00.Model;
using woodcalc_00.Logic;
using System.Reflection;
using System.Windows.Controls;

namespace woodcalc_00._viewmodel
{
    public class CalculationViewModel : BaseViewModel
    {
        private ICommand saveChanges;
        private ICommand deleteCommand;
        private ICommand deleteAllCommand;
        private ICommand editCommand;
        private ICommand clearCommand;
        private ObservableCollection<Log> data;
        private VolumeCalculation currectClass;
        private readonly ILogDataService dataService;
        private string selectedItem;
        private string buttonText;
        private double totalPrice;
        private double totalVolume;
        private int qualityIndex;
        private int typeOfTreeIndex;
        private ObservableCollection<string> typeOfTreeList;

        #region Properties and Commands
        //Propojeni s tlacitkem na pridani hodnoty do databaze
        public ICommand SaveChangesCommand => saveChanges ??= new RelayCommand(SaveToDB, CanAdd);
        //Propojeni s tlacitkem na smazani v tabulce 
        public ICommand DeleteCommand => deleteCommand ??= new RelayCommand<Log>(RemoveLog, CanRemove);
        //vycisteni formulare
        public ICommand ClearCommand =>  clearCommand ??= new RelayCommand(ClearForm);
        //Smazani veskereho obsahu tabulky
        public ICommand DeleteAllCommand => deleteAllCommand ??= new RelayCommand<bool>(DeleteAll);
        //nacteni dat do formulare
        public ICommand EditCommand => editCommand ??= new RelayCommand<Log>(EditLog);

        public ObservableCollection<string> TypeOfTreeList 
        {
            get => typeOfTreeList;
            set
            {
                if (typeOfTreeList != value)
                {
                    typeOfTreeList = value;
                    OnPropertyChanged();
                }
            }
        }
        public List<string> QualityList { get; set; }
        public int QualitySelectedIndex
        {
            get => qualityIndex;
            set
            {
                if (qualityIndex != value)
                {
                    qualityIndex = value;
                    OnPropertyChanged();
                }
            }
        }        
        public int TypeOfTreeSelectedIndex
        {
            get => typeOfTreeIndex;
            set
            {
                if (typeOfTreeIndex != value)
                {
                    typeOfTreeIndex = value;
                    OnPropertyChanged();
                }
            }
        }
        public string SelectedCalculation 
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                ChangeClass(selectedItem);
                OnPropertyChanged();
            }
        }
        public double TotalPrice
        {
            get => totalPrice;
            set
            {
                if (totalPrice != value)
                {
                    totalPrice = value;
                    OnPropertyChanged();
                }
            }
        }
        public double TotalVolume
        {
            get => totalVolume;
            set
            {
                if (totalVolume != value)
                {
                    totalVolume = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ButtonText
        {
            get => buttonText ??= "Přidat";
            set
            {
                buttonText = value;
                OnPropertyChanged();
            }
        }

        //aktualne vybrana trida pro vypocet objemu
        public VolumeCalculation CurrectDeliveredClass
        {
            get => currectClass;
            set
            {
                if (currectClass != value)
                {
                    currectClass = value;
                    OnPropertyChanged();
                }
            }
        }
        //list se vsemi tridami pro vypocet objemu 
        public List<VolumeCalculation> DeliveredClasses { get; }

        //data načtená z databáze
        public ObservableCollection<Log> Data 
        {
            get => data;
            set
            {
                if (data != value)
                {
                    data = value;
                    OnPropertyChanged();
                }
            }
        }
        #region Settings
        public bool TypeOfTreeBox => Settings.Default.TypeOfTreeBox;
        public bool BarkBox => Settings.Default.BarkBox;
        public bool PriceBox => Settings.Default.PriceBox;

        public bool QualityBox => Settings.Default.QualityBox;
        public int DefaultIndex => Convert.ToInt32(Settings.Default.DefalutCalculationMethod);
        public bool TagBox => Settings.Default.TagBox;
        public bool AddMoreItemsBox => Settings.Default.AddMoreItemsBox;

        #endregion
        #endregion
        public CalculationViewModel()
        {
            DeliveredClasses = new List<VolumeCalculation>() { new Huber(), new Smalian(), new Newton(), new CSN480007(), new CSN480009() };
            CalculationMethods = new DataService<Calculation>().GetAll().Select(X => X.TypeOfCalculation).ToList();
            dataService = new LogDataService(new DataService<Log>());
            QualityList = new List<string>(new DataService<Quality>().GetAll().Select(x => x.QualityClass));
            TypeOfTreeList = new ObservableCollection<string>(new DataService<Tree>().GetAll().Select(x => x.TypeOfTree));
            TypeOfTreeSelectedIndex = -1;
            QualitySelectedIndex = -1;
        }
        //Ulozeni do databaze
        private void SaveToDB()
        {
            Log log = CurrectDeliveredClass.SaveLog();
            if (!Data.Any(x => x.Id == log.Id))
            {
                Data.Add(log);
            }
            else
            {
                Data[data.IndexOf(Data.FirstOrDefault(x => x.Id == log.Id))] = log;
            }
            UpdateData();
            if (ButtonText != "Přidat")
            {
                ButtonText = "Přidat";
                ClearForm();
            }
        } 

        //zmena vypoctu a nacteni dat
        private void ChangeClass(string delivered_type) 
        {
            CurrectDeliveredClass = (DeliveredClasses.FirstOrDefault(vm => vm.TypeOfCalculation == delivered_type));
            Data = new ObservableCollection<Log>(dataService.GetLogsByCalculation(delivered_type));
            UpdateData();
            ClearForm();
        }
        private void DeleteAll(bool parameter)
        {
            if (parameter)
            {
                dataService.DeleteAll(Data);
                Data.Clear();
                UpdateData();
                ClearForm();
            }
        }
        private bool CanRemove(Log log) => Data.Contains(log);
        private bool CanAdd()
        {

            if (SelectedCalculation == "ČSN 48 0009")
            {
                return CurrectDeliveredClass.Volume > 0 && !string.IsNullOrEmpty(CurrectDeliveredClass.TypeOfTree) ;
            }
            else
            {
                return CurrectDeliveredClass.Volume > 0;
            }
        }

        private void RemoveLog(Log log)
        {
            dataService.Delete(log.Id);
            Data.Remove(log);
            Data.OrderBy(x => x.Id);
            UpdateData();
            ClearForm();
        }
        private void EditLog(Log log)
        {
            ButtonText = "Uložit změny";
            //CurrectDeliveredClass = DeliveredClasses.FirstOrDefault(x => x.TypeOfCalculation == log.Calculation.TypeOfCalculation);
            CurrectDeliveredClass.EditLog(log);
            if (log.Quality is null)
            {
                QualitySelectedIndex = -1;
            }
            if (log.Tree is null)
            {
                TypeOfTreeSelectedIndex = -1;
            }
        }
        private void UpdateData()
        {
            double price = 0;
            double volume = 0;
            foreach (var item in Data)
            {
                price += item.Value;
                volume += item.Volume;
            }
            TotalVolume = Math.Round(volume,3);
            TotalPrice = Math.Round(price,3);
        }
        private void ClearForm() //Button for clearing the form 
        {
            CurrectDeliveredClass.DiameterBottom = 0;
            CurrectDeliveredClass.DiameterMiddle = 0;
            CurrectDeliveredClass.DiameterTop = 0;
            CurrectDeliveredClass.TreeLength = 0;
            CurrectDeliveredClass.Tag = string.Empty;
            CurrectDeliveredClass.TypeOfTree = string.Empty;
            CurrectDeliveredClass.Quality = string.Empty;
            QualitySelectedIndex= -1;
            TypeOfTreeSelectedIndex = -1;
            ButtonText = "Přidat";
            CurrectDeliveredClass.EditId = 0;
        }
        public void TreeListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var test = sender as ComboBox;
            if (test.SelectedIndex >= 0)
            {
                TypeOfTreeList = new ObservableCollection<string>(new DataService<Tree>().GetAll().Where(x => x.CalculationParametersId == test.SelectedIndex + 1).Select(x => x.TypeOfTree));
                if (CurrectDeliveredClass.EditId > 0)
                {
                    TypeOfTreeSelectedIndex = TypeOfTreeList.IndexOf(Data.FirstOrDefault(x => x.Id == CurrectDeliveredClass.EditId).Tree.TypeOfTree);
                }
            }
            else
            {
                TypeOfTreeList = new ObservableCollection<string>(new DataService<Tree>().GetAll().Select(x => x.TypeOfTree));
            }
        }
    }
}
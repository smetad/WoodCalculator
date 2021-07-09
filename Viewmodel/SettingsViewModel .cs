using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

using woodcalc_00.Properties;
using woodcalc_00.Service.DataServices;

namespace woodcalc_00._viewmodel
{
    public class SettingsUCViewModel : BaseViewModel
    {
        //private ObservableCollection<string> typeOfTrees;
        //private ICommand addToListCommand;
        //private ICommand removeFromListCommand;
        ////Propojeni s tlacitkem na pridani hodnoty do stringlistu
        //public ICommand AddToListCommand => addToListCommand ??= new RelayCommand<string>(AddToList, IsInList);
        ////Propojeni s tlacitkem na odebrani hodnoty ze stringlistu
        //public ICommand RemoveFromListCommand => removeFromListCommand ??= new RelayCommand<string>(RemoveFromList, IsDeletable);

        private string selectedTreeType;
        public SettingsUCViewModel()
        {
            CalculationMethods = new DataService<Calculation>().GetAll().Select(x => x.TypeOfCalculation).ToList();
        }
        public List<string> CalculationsList { get; set; }
        public string SelectedTreeType
        {
            get => selectedTreeType;
            set
            {
                if (selectedTreeType != value)
                {
                    selectedTreeType = value;

                    OnPropertyChanged();
                }
            }
        }
        #region Bark
        public bool BarkBox
        {
            get => Settings.Default.BarkBox;
            set
            {
                if (Settings.Default.BarkBox != value)
                {
                    Settings.Default.BarkBox = value;
                    Settings.Default.Save();
                    Settings.Default.Reload();
                    OnPropertyChanged();
                }
            }
        }
        public string DefaultThickness
        {
            get => Settings.Default.DefaultThickness.ToString();
            set
            {
                if (Settings.Default.DefaultThickness.ToString() != value)
                {
                    var output = double.Parse(value, CultureInfo.CurrentCulture);
                    if (output < 10)
                    {
                        Settings.Default.DefaultThickness = output;
                        Settings.Default.Save();
                        OnPropertyChanged();
                    }
                }
            }
        }
        #endregion
        public string DecimalPlacesCount
        {
            get => Settings.Default.DecimalPlacesCount.ToString();
            set
            {
                if (Settings.Default.DecimalPlacesCount.ToString() != value)
                {
                    var output = Math.Round(Convert.ToDouble(value, CultureInfo.CurrentCulture), 0);
                    Settings.Default.DecimalPlacesCount = output > 15 ? 15 : Convert.ToInt32(output);
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        public bool TypeOfTreeBox
        {
            get => Settings.Default.TypeOfTreeBox;
            set
            {
                if (Settings.Default.TypeOfTreeBox != value)
                {
                    Settings.Default.TypeOfTreeBox = value;
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        //public ObservableCollection<string> TypeOfTrees
        //{
        //    get => typeOfTrees;
        //    set
        //    {
        //        typeOfTrees = value;
        //        OnPropertyChanged();
        //    }
        //}
        public bool QualityBox
        {
            get => Settings.Default.QualityBox;
            set
            {
                if (Settings.Default.QualityBox != value)
                {
                    Settings.Default.QualityBox = value;
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        public bool PriceBox
        {
            get => Settings.Default.PriceBox;
            set
            {
                if (Settings.Default.PriceBox != value)
                {
                    Settings.Default.PriceBox = value;
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        public string PriceCalculation
        {
            get => Settings.Default.PriceCalculation.ToString();
            set
            {
                if (Settings.Default.PriceCalculation.ToString() != value)
                {
                    Settings.Default.PriceCalculation = Convert.ToDouble(value);
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        public bool TagBox
        {
            get => Settings.Default.TagBox;
            set
            {
                if (Settings.Default.TagBox != value)
                {
                    Settings.Default.TagBox = value;
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        public string DefalutCalculationMethod
        {
            get => Settings.Default.DefalutCalculationMethod;
            set
            {
                if (Settings.Default.DefalutCalculationMethod != value)
                {
                    Settings.Default.DefalutCalculationMethod = value;
                    Settings.Default.Save();
                    OnPropertyChanged();
                }
            }
        }
        //private void AddToList(string itemToAdd)
        //{
        //    TypeOfTrees.Add(itemToAdd);
        //    Settings.Default.TypeOfTreeList.Add(itemToAdd);
        //    Settings.Default.Save();
        //}
        //private void RemoveFromList(string itemToDelete)
        //{
        //    TypeOfTrees.Remove(itemToDelete);
        //    Settings.Default.TypeOfTreeList.Remove(itemToDelete);
        //    Settings.Default.Save();
        //}
        //private bool IsInList(string itemToCheck)
        //{
        //    return !TypeOfTrees.Contains(itemToCheck) && itemToCheck != null;
        //}
        //private bool IsDeletable(string itemToDelete)
        //{
        //    return TypeOfTrees.Contains(itemToDelete);
        //}
    }
}
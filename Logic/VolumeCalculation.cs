using System;
using System.Collections.Generic;
using woodcalc_00._service;
using woodcalc_00.Model;
using woodcalc_00.Service;
using woodcalc_00.Service.DataServices;

namespace woodcalc_00._model
{
    public abstract class VolumeCalculation : NotifyPropertyChanged
    {
        private double length;
        private double diameterTop;
        private double diameterMiddle;
        private double diameterBottom;
        private double volume;
        private double logValue;
        private double bark;
        private string typeOfTree;
        private string quality;
        private string tag;
        private string typeOfCalculation;
        private readonly double price;
        private readonly ILogDataService logService;
        public readonly TreeService treeService;
        private readonly CalculationService calculationService;
        private readonly QualityService qualityService;
        private int selectedTreeClass;

        public VolumeCalculation()
        {
            logService = new LogDataService(new DataService<Log>());
            calculationService = new CalculationService(new DataService<Calculation>());
            treeService = new TreeService(new DataService<Tree>());
            qualityService = new QualityService(new DataService<Quality>());
            volume = 0;
            if (Properties.Settings.Default.PriceBox)
            {
                price = Properties.Settings.Default.PriceCalculation;
            }
            bark = Properties.Settings.Default.BarkBox ? Properties.Settings.Default.DefaultThickness : 0;
            DecimalPlacesCount = Properties.Settings.Default.DecimalPlacesCount;
            selectedTreeClass = 0;
        }
        #region Properties
        public List<string> TreeClasses { get; set; }
        public int EditId { get; set; }
        public int SelectedTreeClass
        {
            get { return selectedTreeClass; }
            set
            {
                if (selectedTreeClass != value)
                {
                    selectedTreeClass = value;                    
                    OnPropertyChanged();
                    CalculateVolume();
                }
            }
        }
        public double Bark
        {
            get => bark;
            set
            {
                bark = value;
                OnPropertyChanged();
                CalculateVolume();
            }
        }
        public int DecimalPlacesCount { get; set; }
        public string TypeOfTree
        {
            get => typeOfTree is null ? string.Empty : typeOfTree;

            set
            {
                if (typeOfTree != value && !(value is null))
                {
                    typeOfTree = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Quality
        {
            get
            {
                return quality;
            }

            set
            {
                if (quality != value)
                {
                    quality = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TypeOfCalculation
        {
            get
            {
                return typeOfCalculation;
            }

            set
            {
                if (typeOfCalculation != value)
                {
                    typeOfCalculation = value;
                    OnPropertyChanged();
                }
            }
        }
        public double TreeLength
        {
            get => length;
            set
            {

                    length = value;
                    CalculateVolume();
                    OnPropertyChanged();
                
            }
        }
        public double DiameterTop
        {
            get => diameterTop;
            set
            {
                if (diameterTop != value)
                {
                    diameterTop = value;
                    CalculateVolume();
                    OnPropertyChanged();
                }
            }
        }
        public double DiameterMiddle
        {
            get => diameterMiddle;
            set
            {
                if (diameterMiddle != value)
                {
                    diameterMiddle = value;
                    OnPropertyChanged();
                    CalculateVolume();
                }
            }
        }
        public double DiameterBottom
        {
            get => diameterBottom;
            set
            {
                if (diameterBottom != value)
                {
                    diameterBottom = value;
                    CalculateVolume();
                    OnPropertyChanged();
                }
            }
        }
        public double Price
        {
            get => price;
            set
            {
                if (price != value)
                {
                    Price = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Volume
        {
            get => volume;
            set
            {
                volume = value;
                if (Price != 0)
                {
                    LogValue = CalculateLogValue();
                }
                OnPropertyChanged();
                System.Windows.Input.CommandManager.InvalidateRequerySuggested(); //odstranení prodlevy pro canexecute
            }
        }
        public double LogValue
        {
            get => logValue;
            set
            {
                if (this.logValue != value)
                {
                    this.logValue = value;
                }
                OnPropertyChanged();
            }
        }
        public string Tag
        {
            get => tag;
            set
            {
                if (tag != value)
                {
                    tag = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
        public abstract void CalculateVolume();
        public double CalculateLogValue()
        {
            return Math.Round(Price * Volume, 0);
        }
        public Log CreateLog()
        {
            Log log = new Log()
            {
                DiameterBottom = diameterBottom,
                DiameterMiddle = diameterMiddle,
                DiameterTop = diameterTop,
                Length = TreeLength,
                Value = LogValue,
                Volume = volume,
                Tag = tag,
                Bark = bark,
                Calculation = calculationService
                    .GetEntity(new Calculation { TypeOfCalculation = TypeOfCalculation }),
                Tree = treeService
                    .GetEntity(new Tree { TypeOfTree = TypeOfTree }),
                Quality = qualityService
                    .GetEntity(new Quality { QualityClass = quality }),
            };
            return log;
        }
        public Log SaveLog()
        {
            Log log = CreateLog();
            if (EditId == 0)
            {
                log = logService.Add(log);
            }
            else
            {
                log = logService.Update(EditId, log);
                EditId = 0;
            }
            return log;
        }
        public void EditLog(Log log)
        {
            EditId = log.Id;
            TreeLength = log.Length;
            DiameterTop = log.DiameterTop;
            DiameterMiddle = log.DiameterMiddle;
            DiameterBottom = log.DiameterBottom;
            Volume = log.Volume;
            Bark = log.Bark;
            Tag = log.Tag;
            if (log.Quality != null)
            {
                Quality = log.Quality.QualityClass;
            }
            if (log.Tree != null)
            {
                TypeOfTree = log.Tree.TypeOfTree;
                SelectedTreeClass = log.Tree.CalculationParametersId - 1;
            }            
        }
    }
}


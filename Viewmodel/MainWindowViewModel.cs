using System.Windows.Input;

namespace WoodCalc_WPF._viewmodel
{
    class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel viewModel;
        private ICommand displayCalculation;
        private ICommand displaySettings;
        private ICommand displayExportWindow;

        public MainWindowViewModel()
        {
            if (viewModel is null)
            {
                ViewModel = new CalculationViewModel();
            }
        }
        public BaseViewModel ViewModel
        {
            get => viewModel;
            set
            {
                if (viewModel != value)
                {
                    viewModel = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand DisplayCalculation => displayCalculation ??= new RelayCommand(ChangeVMToCalculation);
        public ICommand DisplaySettings => displaySettings ??= new RelayCommand(ChangeVMToSettings);
        public ICommand DisplayExportWindow => displayExportWindow ??= new RelayCommand(ChangeVMToExport);

        private void ChangeVMToCalculation() => ViewModel = new CalculationViewModel();
        private void ChangeVMToSettings() => ViewModel = new SettingsUCViewModel();
        private void ChangeVMToExport() => ViewModel = new ExportViewModel();

    }
}

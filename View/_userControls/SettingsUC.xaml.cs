using System.Windows.Controls;

namespace WoodCalc_WPF._view._userControls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SettingsUC : UserControl
    {
        public SettingsUC()
        {
            InitializeComponent();
            DataContext = new _viewmodel.SettingsUCViewModel();
        }
    }
}

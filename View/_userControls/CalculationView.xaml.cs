using System.Windows.Forms;
using System.Windows.Controls;
using WoodCalc_WPF._viewmodel;

namespace WoodCalc_WPF._view._userControls
{
    /// <summary>
    /// Interaction logic for Calculation.xaml
    /// </summary>
    public partial class CalculationView : System.Windows.Controls.UserControl
    {
        public CalculationView()
        {
            InitializeComponent();
            DataContext = new CalculationViewModel();
        }

        private void LogDataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Opravdu chce odstranit veškeré záznamy?", "Smazat data", buttons: MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            btnDeleteAll.CommandParameter = result == DialogResult.Yes ? true : (object)false;
        }
    }
}

using Microsoft.Win32;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Controls;

namespace WoodCalc_WPF._view._userControls
{
    /// <summary>
    /// Interakční logika pro ExportView.xaml
    /// </summary>
    public partial class ExportView : System.Windows.Controls.UserControl
    {
        public ExportView()
        {
            InitializeComponent();
            DataContext = new _viewmodel.ExportViewModel();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                UseDescriptionForTitle = true,
                Description = "Vyberte adresář pro ukládání"
            };
            dialog.ShowDialog();
            this.FilePathTextBox.Text = dialog.SelectedPath;
            this.FilePathTextBox.GetBindingExpression(System.Windows.Controls.TextBox.TextProperty).UpdateSource();
        }
    }
}

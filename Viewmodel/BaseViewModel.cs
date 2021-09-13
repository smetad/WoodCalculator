using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using WoodCalc_WPF._model;

namespace WoodCalc_WPF._viewmodel
{
    public abstract class BaseViewModel : NotifyPropertyChanged
    {
        /// <summary>
        /// Calculation method names used in combobox
        /// </summary>
        public List<string> CalculationMethods { get; set; }

        //Event for checking input values; only decimal numbers allowed
        public void Decimal_Checker(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            bool approvedDecimalPoint = false;

            if (e.Text == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
            {
                if (!((TextBox)sender).Text.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
                {
                    approvedDecimalPoint = true;
                }
            }
            if (!(char.IsDigit(e.Text, e.Text.Length - 1) || approvedDecimalPoint))
                e.Handled = true;
        }
    }
}

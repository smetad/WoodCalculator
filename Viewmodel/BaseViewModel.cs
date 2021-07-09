using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;
using woodcalc_00._model;

namespace woodcalc_00._viewmodel
{
    public abstract class BaseViewModel : NotifyPropertyChanged
    {
        //List s nazvy metod pro vypocet objemu pro combobox
        public List<string> CalculationMethods { get; set; }

        //Kontrola vstupnich hodnot - omezeni na desetinna cisla
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

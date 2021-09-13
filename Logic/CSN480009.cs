using System;
using System.Collections.Generic;
using System.Linq;
using WoodCalc_WPF._model;
using WoodCalc_WPF.Model;
using WoodCalc_WPF.Service;
using WoodCalc_WPF.Service.DataServices;

namespace WoodCalc_WPF.Logic
{

    public class CSN480009 : VolumeCalculation
    {
        private readonly List<double[]> parameters;
        public CSN480009()
        {
            TypeOfCalculation = "ČSN 48 0009";
            TreeClasses = new List<string>(treeService.TreeClasses());
            parameters = new List<double[]>(new CalculationParametersService(new DataService<CalculationParameters>()).GetParameters());      
        }
        public override void CalculateVolume()
        {
            try
            {
                Volume = Math.Round(Math.PI
                                    * TreeLength
                                    * Math.Pow(DiameterMiddle - ((2 * parameters[SelectedTreeClass][0]) + (parameters[SelectedTreeClass][1] 
                                    * Math.Pow(DiameterMiddle, parameters[SelectedTreeClass][2]))), 2)
                                    / 40000
                                    , DecimalPlacesCount);
            }
            catch (FormatException)
            {
                Volume = 0;
            }
        }
    }
}

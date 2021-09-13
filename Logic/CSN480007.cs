using System;

namespace WoodCalc_WPF._model
{
    class CSN480007 : VolumeCalculation
    {
        public CSN480007()
        {
            TypeOfCalculation = "ČSN 48 0007";
        }

        public override void CalculateVolume()
        {
            double barkValue = Convert.ToDouble(Bark);
            try
            {
                Volume = Math.Round(
                    Math.PI
                    * Math.Pow(DiameterMiddle - barkValue, 2)
                    * TreeLength
                    / 40000,
                    DecimalPlacesCount);
            }
            catch (FormatException)
            {

                Volume = 0;
            }
        }
    }
}


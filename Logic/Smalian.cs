using System;

namespace WoodCalc_WPF._model
{
    class Smalian : VolumeCalculation
    {
        public Smalian()
        {
            TypeOfCalculation = "Smalianův vzorec";
        }
        public override void CalculateVolume()
        {
            double barkValue = Convert.ToDouble(Bark);
            try
            {
                Volume = Math.Round(Math.PI / 4 * ((Math.Pow(DiameterTop - barkValue, 2) + Math.Pow(DiameterBottom - barkValue, 2)) / 2) * TreeLength * 0.0001, DecimalPlacesCount);
            }
            catch (FormatException)
            {
                Volume = 0;
            }
        }
    }
}


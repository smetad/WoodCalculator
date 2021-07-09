using System;

namespace woodcalc_00._model
{
    class Newton : VolumeCalculation
    {
        public Newton()
        {
            TypeOfCalculation = "Newtonův vzorec";
        }
        public override void CalculateVolume()
        {
            try
            {
                double barkValue = Convert.ToDouble(Bark);
                Volume = Math.Round(Math.PI / 4 * ((Math.Pow(DiameterTop - barkValue, 2) + (4 * Math.Pow(DiameterMiddle - Bark, 2)) + Math.Pow(DiameterBottom - Bark, 2)) / 6) * TreeLength * 0.0001, DecimalPlacesCount);
            }
            catch (FormatException)
            {

                Volume = 0;
            }
        }
    }
}


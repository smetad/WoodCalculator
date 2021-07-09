using System;

namespace woodcalc_00._model
{
    class Huber : VolumeCalculation
    {
        public Huber()
        {
            TypeOfCalculation = "Huberův vzorec";
        }
        public override void CalculateVolume()
        {
            double barkValue = Convert.ToDouble(Bark);
            try
            {
                Volume = Math.Round(Math.PI / 4 * Math.Pow(DiameterMiddle - barkValue, 2) * TreeLength * 0.0001, DecimalPlacesCount);
            }
            catch (FormatException)
            {
                Volume = 0;
            }
        }
    }
}


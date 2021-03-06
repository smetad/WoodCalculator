using System.ComponentModel.DataAnnotations;
using WoodCalc_WPF.Model;

namespace WoodCalc_WPF
{
    public class Log : Entity
    {
        public double DiameterTop { get; set; }
        public double DiameterMiddle { get; set; }
        public double DiameterBottom { get; set; }
        [Required]
        public double Volume { get; set; }
        [Required]
        public double Length { get; set; }
        public double Value { get; set; }
        public double Bark { get; set; }
        public string Tag { get; set; }

        public virtual Quality Quality { get; set; }
        public virtual Tree Tree { get; set; }
        public virtual Calculation Calculation { get; set; }
    }
}

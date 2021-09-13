using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WoodCalc_WPF.Model;

namespace WoodCalc_WPF
{
    public class Calculation : Entity
    {
        public string TypeOfCalculation { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<CalculationParameters> CalculationParameters { get; set; }
    }
}

using System.Collections.Generic;
using WoodCalc_WPF.Model;

namespace WoodCalc_WPF
{
    public class Tree : Entity
    {
        public string TypeOfTree { get; set; }
        public int CalculationParametersId { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual CalculationParameters CalculationParameters { get; set; }
    }
}

using System.Collections.Generic;
using woodcalc_00.Model;

namespace woodcalc_00
{
    public class Tree : Entity
    {
        public string TypeOfTree { get; set; }
        public int CalculationParametersId { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual CalculationParameters CalculationParameters { get; set; }
    }
}

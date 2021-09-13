using System.Collections.Generic;

namespace WoodCalc_WPF.Model
{
    public class Quality : Entity
    {
        public string QualityClass { get; set; }
        public ICollection<Log> Logs { get; set; }
    }
}

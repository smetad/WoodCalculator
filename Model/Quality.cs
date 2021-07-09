using System.Collections.Generic;

namespace woodcalc_00.Model
{
    public class Quality : Entity
    {
        public string QualityClass { get; set; }
        public ICollection<Log> Logs { get; set; }
    }
}

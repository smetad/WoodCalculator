using System.Collections.Generic;

namespace woodcalc_00.Model
{
    public class CalculationParameters : Entity
    {
        public double E0 { get; set; }
        public double E1 { get; set; }
        public double E2 { get; set; }
        public string Name { get; set; }
        public int CalculationId { get; set; }
        public ICollection<Tree> Trees { get; set; }
        public Calculation Calculation { get; set; }
    }
}

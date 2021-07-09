using System.Collections.Generic;
using System.Linq;
namespace woodcalc_00.Service.DataServices
{
    public class CalculationService : BaseService<Calculation>
    {
        private readonly IDataService<Calculation> dataService;

        public CalculationService(IDataService<Calculation> dataService) : base(dataService)
        {
            this.dataService = dataService;
        }
        public override int FindId(Calculation enitiy)
        {
            List<Calculation> list = new List<Calculation>(dataService.GetAll()); 
            return list[list.FindIndex(x => x.TypeOfCalculation == enitiy.TypeOfCalculation)].Id;
        }
    }
}

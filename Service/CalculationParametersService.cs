using System.Collections.Generic;
using System.Linq;
using woodcalc_00.Model;
using woodcalc_00.Service.DataServices;

namespace woodcalc_00.Service
{
    class CalculationParametersService : BaseService<CalculationParameters>
    {
        private readonly IDataService<CalculationParameters> dataService;
        List<double[]> parameters;
        private readonly List<CalculationParameters> calculationParametersList;
        public CalculationParametersService(IDataService<CalculationParameters> dataService) : base(dataService)
        {
            this.dataService = dataService;
            calculationParametersList = dataService.GetAll().ToList();
        }
        public List<double[]> GetParameters()
        {
            parameters = new List<double[]>();
            for (int i = 0; i < calculationParametersList.Count; i++)
            {
                parameters.Add(new double[] { calculationParametersList[i].E0, calculationParametersList[i].E1, calculationParametersList[i].E2 });
            }
            return parameters;
        }
    }
}

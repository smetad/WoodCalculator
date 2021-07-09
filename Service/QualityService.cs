using System;
using System.Collections.Generic;
using System.Text;
using woodcalc_00.Model;
using woodcalc_00.Service.DataServices;

namespace woodcalc_00.Service
{
    public class QualityService : BaseService<Quality>
    {
        private readonly IDataService<Quality> dataService;
        public QualityService(IDataService<Quality> dataService) : base(dataService)
        {
            this.dataService = dataService;
        }
        public override int FindId(Quality entity)
        {
            List<Quality> list = new List<Quality>(dataService.GetAll());
            return list[list.FindIndex(x => x.QualityClass == entity.QualityClass)].Id;
        }

    }
}

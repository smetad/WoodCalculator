using System;
using System.Collections.Generic;
using System.Text;
using WoodCalc_WPF.Model;
using WoodCalc_WPF.Service.DataServices;

namespace WoodCalc_WPF.Service
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

using System.Collections.Generic;
using WoodCalc_WPF.Service.DataServices;
using System;
using WoodCalc_WPF.Model;
using System.Linq;

namespace WoodCalc_WPF.Service
{
    public class TreeService : BaseService<Tree>
    {
        private readonly IDataService<Tree> dataService;
        private readonly List<Tree> trees;
        private readonly List<string> parameterClasses;
        public TreeService(IDataService<Tree> dataService) : base(dataService)
        {
            this.dataService = dataService;
            trees = new List<Tree>(dataService.GetAll());
            parameterClasses = new List<string>(new DataService<CalculationParameters>()
                .GetAll()
                .Select(x => x.Name));
        }

        //kontrola existence zadanych dat v databazi
        public override int FindId(Tree tree)
        {
            List<Tree> list = new List<Tree>(dataService.GetAll());
            return list[list.FindIndex(x => x.TypeOfTree == tree.TypeOfTree)].Id;
        }
        public IEnumerable<string> TreeClasses()
        {
            List<string> returnList = new List<string>();          
            for (int i = 1; i < 6; i++)
            {               
                string values = parameterClasses[i - 1] + "\n";
                foreach (var item in trees)
                {
                    if (item.CalculationParametersId == i)
                    {
                        values = values + item.TypeOfTree + ", ";
                    }
                }
                returnList.Add(values.Remove(values.Length - 2));
            }
            return returnList;
        }
    }
}

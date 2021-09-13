using System;
using System.Collections.Generic;
using System.Text;

namespace WoodCalc_WPF.Service.DataServices
{
    interface ILogDataService : IDataService<Log>
    {
        IEnumerable<Log> GetLogsByCalculation(string typeOfCalculation);
        IEnumerable<Log> GetLogs();
        public void DeleteAll(IEnumerable<Log> deleteEntities);
    }
}

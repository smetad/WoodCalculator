using System;
using System.Collections.Generic;
using System.Text;

namespace woodcalc_00.Service.DataServices
{
    interface ILogDataService : IDataService<Log>
    {
        IEnumerable<Log> GetLogsByCalculation(string typeOfCalculation);
        IEnumerable<Log> GetLogs();
        public void DeleteAll(IEnumerable<Log> deleteEntities);
    }
}

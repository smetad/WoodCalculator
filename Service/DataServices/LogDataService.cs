using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WoodCalc_WPF.Service.DataServices;

namespace WoodCalc_WPF._service
{
    public class LogDataService : ILogDataService
    {
        private readonly IDataService<Log> dataService;

        public LogDataService(IDataService<Log> dataService)
        {
            this.dataService = dataService;            
        }

        public IEnumerable<Log> GetAll()
        {
            return dataService.GetAll();
        }

        public Log Get(int id)
        {
            return dataService.Get(id);
        }
        public Log Add(Log entity)
        {
            return dataService.Add(entity);
        }
        public void Delete(int id)
        {
            dataService.Delete(id);
        }
        public Log Update(int id, Log entity)
        {
            Log log = dataService.Update(id, entity);
            return log;
        }

        public IEnumerable<Log> GetLogsByCalculation(string typeOfCalculation)
        {
            return GetLogs()
                .Where(x => x.Calculation.TypeOfCalculation == typeOfCalculation)
                .ToList();
        }

        public void DeleteAll(IEnumerable<Log> deleteEntities)
        {
            using LogContext context = new LogContext();
            context.RemoveRange(context.Logs);
            context.SaveChanges();
        }

        public IEnumerable<Log> GetLogs()
        {
            using LogContext db = new LogContext();
            IEnumerable<Log> entities = db.Logs
                .Include(a => a.Calculation)
                .Include(a => a.Quality)
                .Include(a => a.Tree)
                .ToList();
            return entities;
        }
    }
}

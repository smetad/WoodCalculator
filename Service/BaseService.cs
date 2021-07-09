using System.Collections.Generic;
using System.Linq;
using woodcalc_00.Service.DataServices;

namespace woodcalc_00.Service
{
    public abstract class BaseService<T>
    {
        private readonly IDataService<T> dataService;
        public T ReturnValue { get; set; }
        protected BaseService(IDataService<T> dataService)
        {
            this.dataService = dataService;
        }
        public T GetEntity(T entity)
        {
            try
            {
                return dataService.Get(FindId(entity));
            }
            catch (System.Exception)
            {
                return ReturnValue;
            }
        }
        public virtual int FindId(T entity)
        {
            return -1;
        }
    }
}

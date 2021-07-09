using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace woodcalc_00.Service.DataServices
{
    public interface IDataService<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Add(T entity);

        T Update(int id, T entity);

        void Delete(int id);
    }
}

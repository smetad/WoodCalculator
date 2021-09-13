using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WoodCalc_WPF.Service.DataServices
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

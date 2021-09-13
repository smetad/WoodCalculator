using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WoodCalc_WPF.Model;

namespace WoodCalc_WPF.Service.DataServices
{
    public class DataService<T> : IDataService<T> where T : Entity
    {
        public T Add(T entity)
        {
            T returnValue;
            using (var context = new LogContext())
            {
                context.ChangeTracker.TrackGraph(entity, note =>
                {
                    note.Entry.State = !note.Entry.IsKeySet ? EntityState.Added : EntityState.Unchanged;
                });
                context.SaveChanges();
                returnValue = context.Set<T>().OrderBy(x => x.Id).LastOrDefault();
            }
            return returnValue;
        }

        public void Delete(int id)
        {
            using var context = new LogContext();
            T entity = context.Set<T>().FirstOrDefault(x => x.Id == id);
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            T returnValue;
            using (var context = new LogContext())
            {
                returnValue = context.Set<T>().FirstOrDefault(x => x.Id == id);
            }
            return returnValue;
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> list;
            using (var context = new LogContext())
            {
                list = context.Set<T>().ToList();
            }
            return list;
        }

        public T Update(int id, T entity)
        {
            using (var context = new LogContext())
            {
                entity.Id = id;
                context.Update(entity);
                context.SaveChanges();
            }
            return entity;
        }
        //public IEnumerable<T> GetMultipleTables(string[] includes)
        //{
        //    IEnumerable<T> list;
        //    using (var context = new LogContext())
        //    {
        //        list = includes.Aggregate(context.Set<T>().AsQueryable(), (query, path) => query.Include(path)).ToList();
        //    }
        //    return list;
        //}
    }
}

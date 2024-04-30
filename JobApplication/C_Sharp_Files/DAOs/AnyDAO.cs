using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class AnyDAO<T> where T : class
    {
        protected JobAppDFEntities db = new JobAppDFEntities();
        protected IQueryable<T> query;

        public List<T> GetList()
        {
            return db.Set<T>().ToList();
        }

        public T GetObject(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Insert(T anyObject)
        {
            db.Set<T>().Add(anyObject);
            db.SaveChanges();
        }

        public void Delete(T anyObject)
        {
            db.Set<T>().Remove(anyObject);
            db.SaveChanges();
        }
    }
}

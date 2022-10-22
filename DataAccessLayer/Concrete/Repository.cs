using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c=new Context();
        DbSet<T> _object;

        public Repository()
        {
            _object=c.Set<T>();  //Context üzerinden gönderilen sınıf, object isimli file'a atanır.
        }
        public int Delete(T parameter)
        {
            _object.Remove(parameter);
            return c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T parameter)
        {
            _object.Add(parameter);
            return c.SaveChanges();
        }

        public int Update(T parameter)
        {
            return c.SaveChanges();
        }
    }
}

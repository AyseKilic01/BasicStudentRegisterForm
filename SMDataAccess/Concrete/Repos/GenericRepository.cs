using SMDataAccess.Abstract;
using SMEntity.Concrete.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SMDataAccess.Concrete.Repos
{
    public class GenericRepository<T> : IRepository<T> where T: class
    {
        StudentManagementEntities c = new StudentManagementEntities();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Add(T prop)
        {
            _object.Add(prop);
            c.SaveChanges();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.ToList();
        }

        public void Update(T prop)
        {
            c.SaveChanges();
        }
    }
}

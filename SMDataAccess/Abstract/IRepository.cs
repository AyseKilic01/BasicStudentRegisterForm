using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMDataAccess.Abstract
{
    public interface IRepository<T> where T: class
    {
        List<T> List();
        void Add(T prop);
        void Update(T prop);
        void Delete(T p);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}

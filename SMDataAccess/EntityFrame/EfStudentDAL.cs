using SMDataAccess.Abstract;
using SMDataAccess.Concrete.Repos;
using SMEntity.Concrete.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMDataAccess.EntityFrame
{
    public class EfStudentDAL : GenericRepository<Student>, IStudentDAL
    {
        
    }
}

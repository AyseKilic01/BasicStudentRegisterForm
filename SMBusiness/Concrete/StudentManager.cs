using SMBusiness.Abstract;
using SMDataAccess.Abstract;
using SMEntity.Concrete.DataModel;
using System.Collections.Generic;
namespace SMBusiness.Concrete
{
    public class StudentManager : IService<Student>
    {
        IStudentDAL _dal;

        public StudentManager(IStudentDAL dal)
        {
            _dal = dal;
        }
        public void Add(Student student)
        {
            _dal.Add(student);
        }
        public void Delete(Student student)
        {
            _dal.Delete(student);
        }
        public void Update(Student student)
        {
            _dal.Update(student);
        }
        public List<Student> GetAllBL()
        {
            return _dal.List();
        }
        public List<Student> GetAllBL(Student p)
        {
            return _dal.List();
        }
    }
}

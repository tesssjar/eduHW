using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IStudentsService
    {
        public void AddStudent();
        public void DeleteStudent(int id);
        public List<Student> GetAllStudents();
        public Student GetStudent(int Id);
    }
}

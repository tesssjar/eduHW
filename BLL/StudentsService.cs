using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class StudentsService : IStudentsService
    {
        private readonly IRepository<Student> _repository;

        StudentsService(IRepository<Student> repository) 
        {
            _repository = repository;
        } 

        public void AddStudent(string name, string lastname, string favsubj, int age)
        {
            var student = new Student(name, lastname, age, favsubj);
            _repository.studList.Add(student);
            _repository.Save();
        }

        public List<Student> GetAllStudents()
        {
            return _repository.studList;
        }

        public void DeleteStudent(int Id)
        {
            var selectedStudent = from s in _repository.studList
                              where Id == s.Id
                              select s;
            foreach (var stud in selectedStudent)
            {
                _repository.studList.Remove(stud);
            }
            _repository.Save();
        }

        public Student GetStudent(int Id)
        {
            var selectedStudent = from s in _repository.studList
                                  where Id == s.Id
                                  select s;
            foreach (var stud in selectedStudent)
            {
                return stud;
            }
            return null;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Id = 0;
        public string FavSubject { get; set; }

        public Student(string name, string lastName, int age, string favSubject)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            FavSubject = favSubject;
            Id++;
        }
    }
}

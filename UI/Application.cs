using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace UI
{
    public class Application
    {
        private readonly IStudentsService _studservice;

        Application(IStudentsService studservice)
        {
            _studservice = studservice;
        }
        public void Run()
        {
            Console.WriteLine("1 - set a new student");
            Console.WriteLine("2 - get a list of students");
            Console.WriteLine("3 - get an information about a specific student");
            Console.WriteLine("4 - delete one of the students");

    NewAction:

            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    Console.WriteLine("Enter a name, last name, age and favorite subject of student:");
                    string name = Console.ReadLine();
                    string lastname = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());
                    string favsubj = Console.ReadLine();
                    _studservice.AddStudent(name, lastname, favsubj, age);
                    break;

                case "2":
                    List<Student> studList = _studservice.GetAllStudents();
                    foreach (Student stud in studList)
                    {
                        Console.WriteLine("Student " + stud.Id);
                        Console.WriteLine(stud.Name);
                        Console.WriteLine(stud.LastName);
                        Console.WriteLine(stud.Age);
                        Console.WriteLine(stud.FavSubject);
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter an id:");
                    int Id = int.Parse(Console.ReadLine());
                    Student specStud = _studservice.GetStudent(Id);
                    Console.WriteLine("Student " + specStud.Id);
                    Console.WriteLine(specStud.Name);
                    Console.WriteLine(specStud.LastName);
                    Console.WriteLine(specStud.Age);
                    Console.WriteLine(specStud.FavSubject);
                    break;

                case "4":
                    Console.WriteLine("Enter an id:");
                    int delId = int.Parse(Console.ReadLine());
                    _studservice.DeleteStudent(delId);
                    break;

                default:
                    Console.WriteLine("Undefined action!");
                    break;
            }

            Console.WriteLine("What do you want to do next? (1 - new action, any other key - exit)");

            string step = Console.ReadLine();

            if (step == "1")
            {
                goto NewAction;
            }
        }
    }
}

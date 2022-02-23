using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Application
    {
        public void Run() 
        {
            Console.WriteLine("1 - set a new student");
            Console.WriteLine("2 - get a list of students");
            Console.WriteLine("3 - get an information about a specific student");
            Console.WriteLine("4 - delete one of the students");

            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Undefined action!");
                    break;
            }
    }
}

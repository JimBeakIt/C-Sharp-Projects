using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee eName = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            eName.SayName();
            Console.ReadLine();
        }
    }
}

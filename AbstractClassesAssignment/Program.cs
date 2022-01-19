using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee iName = new Employee
            {
                firstName = "Sample",
                lastName = " Student"
            };

            iName.SayName();
            Console.ReadLine();

            Employee leave = new Employee();
            {
                leave.Quit();
                Console.ReadLine();
            }
        }
    }
}

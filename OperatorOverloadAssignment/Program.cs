using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee example = new Employee();

            example.FirstName = "Harry";
            example.LastName = "Potter";
            example.ID = 20018;

            Employee example2 = new Employee();
            example2.FirstName = "James";
            example2.LastName = "Bond";
            example2.ID = 62007;

            Console.WriteLine(example == example2);
            Console.ReadLine();
        }
    }
}

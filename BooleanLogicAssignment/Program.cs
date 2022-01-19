using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string whatAge = Console.ReadLine();
            int whaAge = Convert.ToInt32(whatAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI violation? Please enter 'True' or 'False'.");
            string duiV = Console.ReadLine();
            bool dV = Convert.ToBoolean(duiV);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string speedT = Console.ReadLine();
            int speT = Convert.ToInt32(speedT);
            Console.ReadLine();

            Console.WriteLine("Qualified?");
            bool result = (whaAge > 15 && dV == false && speT < 4);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}

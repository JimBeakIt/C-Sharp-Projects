using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string hourRate1 = Console.ReadLine();
            float hR1 = Convert.ToInt32(hourRate1);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hourWork1 = Console.ReadLine();
            float hW1 = Convert.ToInt32(hourWork1);
            Console.ReadLine();

            Console.WriteLine("Person2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            string hourRate2 = Console.ReadLine();
            float hR2 = Convert.ToInt32(hourRate2);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string hourWork2 = Console.ReadLine();
            float hW2 = Convert.ToInt32(hourWork2);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            float annSal1 = hR1 * hW1;
            float sal1 = annSal1 * 52;
            Console.WriteLine(sal1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2:");
            float annSal2 = hR2 * hW2;
            float sal2 = annSal2 * 52;
            Console.WriteLine(sal2);
            Console.ReadLine();

            Console.WriteLine("Person 1 makes more money than Person 2");
            bool moreM = sal1 > sal2;
            Console.WriteLine(moreM);
            Console.ReadLine();
        }
    }
}

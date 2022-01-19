using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Operation");
            Console.ReadLine();

            Console.WriteLine("Choose any number and I'll multiply it by 50.");
            string fiftyMultiply = Console.ReadLine();
            int fiftyMul = Convert.ToInt32(fiftyMultiply);
            int total = fiftyMul * 50;
            Console.WriteLine("The answer is: " + total);
            Console.ReadLine();

            Console.WriteLine("Choose any number and I'll add 25 to it.");
            string twenfiveAdd = Console.ReadLine();
            int twefivAdd = Convert.ToInt32(twenfiveAdd);
            int total1 = twefivAdd + 25;
            Console.WriteLine("The answer is: " + total1);
            Console.ReadLine();

            Console.WriteLine("Choose any number and I'll divide it by 12.5.");
            string twefiveDivide = Console.ReadLine();
            double twefivDiv = Convert.ToInt32(twefiveDivide);
            double total2 = twefivDiv / 12.5;
            Console.WriteLine("The answer is: " + total2);
            Console.ReadLine();

            Console.WriteLine("Choose any number and i'll check if it's greater than 50.");
            string fiftybool = Console.ReadLine();
            int fifbool = Convert.ToInt32(fiftybool);
            bool total3 = fifbool > 50;
            Console.WriteLine("The answer is: " + total3);
            Console.ReadLine();

            Console.WriteLine("Choose any number and I'll divide it by 7 and display the remainder.");
            string sevenRemain = Console.ReadLine();
            int sevRem = Convert.ToInt32(sevenRemain);
            int total4 = sevRem % 7;
            Console.WriteLine("The answer is: " + total4);
            Console.ReadLine();
        }
    }
}

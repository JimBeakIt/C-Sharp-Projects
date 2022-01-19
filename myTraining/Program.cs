using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Conner";

            //if (name == "James")
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else if (name == "Conner")
            //{
            //    Console.WriteLine("Conner!!!!");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //Console.ReadLine();

            //if (3 != 3)
            //{
            //    Console.WriteLine("Yeah!");
            //}           
            //else
            //{
            //    Console.WriteLine("err what");
            //}
            //Console.ReadLine();

            //int num1 = 8;
            //int num2 = 11;
            //if(num1 > num2)
            //{
            //    Console.WriteLine("It's bigger!");
            //}
            //else
            //{
            //    Console.WriteLine("Small aint ya");
            //}
            //Console.ReadLine();

            //int age = 17;

            //if (age <= 18)
            //{
            //    Console.WriteLine("no no!");
            //}
            //else
            //{
            //    Console.WriteLine("sure thing");
            //}
            //Console.ReadLine();

            //int num1 = 13;
            //int num2 = 17;

            //string result = num1 > num2 ?  "1 bigger" : "2 bigger";
            //Console.WriteLine(result);
            //Console.ReadLine();

            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            Console.ReadLine();
        }
    }
}

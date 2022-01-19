using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Hello", "Cake", "Bye", "Car", "Sigh", "Laugh", "Moon" };

            Console.WriteLine("Select an index between 0 and 6, I'll then display the string at that index on the screen.");
            int number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 > 6)
            {
                Console.WriteLine("This index doesn't exist.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(strArray[number1]);
                Console.ReadLine();
            }

            int[] intArray = { 32, 1, 23, 41, 2, 9, 15 };

            Console.WriteLine("Select an index between 0 and 6, I'll then display the interger at that index on the screen.");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 > 6)
            {
                Console.WriteLine("This index doesn't exist.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(intArray[number2]);
                Console.ReadLine();
            }

            List<string> intList = new List<string>();
            intList.Add("Hi");
            intList.Add("James");
            intList.Add("Good");
            intList.Add("Morning");

            Console.WriteLine("Select an index between 0 and 3, then I'll display the content at that index on the screen.");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 > 3)
            {
                Console.WriteLine("This index doesn't exist.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(intList[number3]);
                Console.ReadLine();
            }
        }
    }
}

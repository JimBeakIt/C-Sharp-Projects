using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 20;
            //while (i <= 30)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();

            int i = 9;

            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i < 60);
            Console.ReadLine();
        }
    }
}

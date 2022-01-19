using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            

            Console.WriteLine("Enter a number:");
            int enterNum = Convert.ToInt32(Console.ReadLine());

            DateTime now2 = now.AddHours(enterNum);
            Console.WriteLine("Updated time is: " + now2.ToString());
            Console.ReadLine();
        }
    }
}

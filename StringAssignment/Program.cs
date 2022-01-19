using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string userName1 = "James";
            //string userName2 = "Rumey";
            //string userName3 = "Larry";
            //string dateString = DateTime.Today.ToShortDateString();

            //userName2 = userName2.ToUpper();

            //string str = "Hello " + userName1 + ", " + userName2 + " and " + userName3  + ". Today is " + dateString + ".";
            //System.Console.WriteLine(str);
            
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("I live in the county of Essex, \nin England, \nUnited Kingdom.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

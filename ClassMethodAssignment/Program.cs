using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            VoiMeth ex = new VoiMeth();
            ex.sum(20, 40);

            Console.ReadLine();

            VoiMeth n = new VoiMeth();

            int a, b;

            n.getValues(out a, out b);

            Console.WriteLine("The result is: " + a / b);
            Console.ReadLine();

            // Creating Object
            VoiMeth obj = new VoiMeth();

            obj.Identity("James", 1);
            obj.Identity(2, "James");

            Console.ReadLine();
        }
    }
}

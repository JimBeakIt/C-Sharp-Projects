using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    public class VoiMeth
    {
        public void sum(int a, int b)
        {
            Console.WriteLine((a + b) / 2);
        }

        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter a number and I'll divide it by 2: ");
            x = Convert.ToInt32(Console.ReadLine());

            y = 2;
        }

        public void Identity(String name, int id)
        {

            Console.WriteLine("Name1 : " + name + ", "
                            + "Id1 : " + id);
        }

        public void Identity(int id, String name)
        {

            Console.WriteLine("Name2 : " + name + ", "
                            + "Id2 : " + id);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int x = 56;
           // x = 67;
            Console.WriteLine(x);

            double b = 56.90;
            Console.WriteLine(Convert.ToInt32(b));

            Console.WriteLine(b.GetType());

            String d = Convert.ToString(b);

            Console.WriteLine(d.GetType());

            // USER INPUT!
            String name = Console.ReadLine();
            //char character = Console.ReadLine();
            //Console.WriteLine("My name is "+name+ character);


        }
    }
}

// AGENDA OF DAY 3 !!!
// 1- CONSTANTS !!
// 2- TYPE CASTING !!
// 3- GETTYPE METHOD !!
// 4- USER INPUT !!

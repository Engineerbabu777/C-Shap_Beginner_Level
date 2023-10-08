using System;

namespace C_sharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WRITE THING ON SAME LINE!
            Console.Write("on same line ");
            Console.WriteLine("hello from same line");
            // ON DIFFERENT LINES!
            Console.WriteLine("Hell from different Lines");


            // LEARNING ABOUT VARAIABLES!
            int x; // VARIABLE X IS DECLARED OF TYPE INTEGER!!
            int y = 0; // VARIABLE Y IS BEING INITIALIZED && DECLARED OF TYPE INTEGER!
            char z = 'C'; // VARIABLE Z OF TYPE CHARACTER!
            String a = "Hello Bacho!!"; // VARIABLE A OF TYPE STRING STORES MULTIBLE CHARACTERS!
            bool b = false; // VARAIBLE B OF TYPE BOOLEAN(TRUE?FALSE)!
            float f = 50.611f;
            double g = 600.67;

            int c = 15;
            int d = 16;
            int e = c + d;
            Console.WriteLine("SUM IS: "+e+' '+f+' '+g);

            Console.ReadKey();



        }
    }
}

// LEARNT SO FAR !!
// 1- SINGLE MULTI-LINE OUTPUTS!
// 2- COMMENTS(SINGLE LINE AND MULTI-LINE)!
// 3- VARIABLES( STRINGS/BOOLEAN/NUMBERS )!
// 4- OPERATORS(+ - * / % ++ --)!

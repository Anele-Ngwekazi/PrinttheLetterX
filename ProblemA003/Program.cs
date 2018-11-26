using System;

namespace ProblemA003
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemA003 test = new ProblemA003();
            // test from 0 to 9
            // N.B will return line of error
            for (int i = 0; i < 10; i++)
            {
                test.PrinttheLetterX(i);
            }
            

            Console.ReadKey();
        }

    }

}

using System;

namespace ProblemA003
{

    public class ProblemA003
    {
        public void PrinttheLetterX(int sizeOfX)
        {
            if (sizeOfX > 9 || sizeOfX < 1)
            {
                Console.WriteLine("(size Of X must be between 1-9 (inclusive of 1 and 9).");
                Console.WriteLine();
                return;
            }
            int count = -sizeOfX;
            for (int i = 0; i <= 25; i++)
            {
                for (int j = 0; j < 79; j++)
                {
                
                    if ((i == 9 || i == 19) && j == 0)
                    {
                        Console.Write((i + 1) / 10);
                    }
                    else if ((j == 39 - sizeOfX) && (i == 12 - sizeOfX) || (j == 39 + sizeOfX) && (i == 12 + sizeOfX)
                        || (j == 39 - sizeOfX) && (i == 12 + sizeOfX) || (j == 39 + sizeOfX) && (i == 12 - sizeOfX))
                    {
                        Console.Write("$");
                    }
                    else if ((j+1)%10==0)
                    {
                        Console.Write((j + 1) / 10);
                    }
                    else
                    {
                        Console.Write("=");
                    }
                }
                if (i == (12 - sizeOfX) && sizeOfX > count)
                    sizeOfX--;
                Console.WriteLine();
            }
                Console.WriteLine();
        }

    }

}

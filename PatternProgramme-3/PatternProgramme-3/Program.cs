using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgramme_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }

                Console.WriteLine("\n");
            }
            for (row = n-1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

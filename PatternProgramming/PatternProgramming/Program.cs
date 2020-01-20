using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pattern Programming 
            //1
            //1 2
            //1 2 3
            //1 2 3 4 
            //1 2 3 4 5


            int n=5, row, col;
            
            for (row = 1; row <= n; row++)
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

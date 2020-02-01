using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterprogramme_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Pattern Programming-1
            //        1
            //      2 1
            //    3 2 1
            //  4 3 2 1
            //5 4 3 2 1

            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= n-row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <=row; col++)
                {
                    Console.Write(col);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */

            //Pattern Programming-1
            //        1
            //      2 2
            //    3 3 3
            //  4 4 4 4
            //5 5 5 5 5

            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }
                for (col = 1; col <= row; col++)
                {
                    Console.Write(row);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

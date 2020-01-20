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

            //Pattern Programming-1
            //1
            //1 2
            //1 2 3
            //1 2 3 4 
            //1 2 3 4 5
            /*

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
            */

            //Pattern Programming-2
            //1
            //2 2
            //3 3 3
            //4 4 4 4 
            //5 5 5 5 5
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(row);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */

            //Pattern Programming-3
            //1
            //1 0
            //1 0 1
            //1 0 1 0
            //1 0 1 0 1
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(col % 2);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */

            //Pattern Programming-4
            //1
            //0 0
            //1 1 1
            //0 0 0 0
            //1 1 1 1 1
            /*
             int n = 5, row, col;

             for (row = 1; row <= n; row++)
             {
                 for (col = 1; col <= row; col++)
                 {
                     Console.Write(row % 2);
                 }

                 Console.WriteLine("\n");
             }
             Console.ReadKey();
             */

            //Pattern Programming-5
            //A
            //A B
            //A B C
            //A B C D
            //A B C D E
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(col + 64));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-6
            //A
            //B B
            //C C C
            //D D D D
            //E E E E E
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(row + 64));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */

            //Pattern Programming-7
            //a
            //a b
            //a b c
            //a b c d
            //a b c d e
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(col + 96));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-8
            //a
            //b b
            //c c c
            //d d d d
            //e e e e e
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(row + 96));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-9
            //*
            //* *
            //* * *
            //* * * *
            //* * * * *
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-10
            //#
            //# #
            //# # #
            //# # # #
            //# # # # #
            ///*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("# ");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            //*/
        }
    }
}

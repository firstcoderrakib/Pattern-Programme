using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_Programme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pattern Programming-1
            //1 2 3 4 5 
            //1 2 3 4
            //1 2 3 
            //1 2
            //1
            /*
            int n = 5, row, col;

            for (row = n; row>=1; row--)
            {
                for (col = row; col >= 1; col--)
                {
                    Console.Write(col);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-2
            //5 5 5 5 5 
            //4 4 4 4
            //3 3 3 
            //2 2
            //1
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
            {
                for (col = row; col >= 1; col--)
                {
                    Console.Write(row);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-3
            //1 0 1 0 1
            //1 0 1 0 
            //1 0 1
            //1 0
            //1
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
            {
                for (col = row; col >= 1; col--)
                {
                    Console.Write(col % 2);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-4
            //1 1 1 1 1
            //0 0 0 0
            //1 1 1
            //0 0 
            //1
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
            {
                for (col = row; col >= 1; col--)
                {
                    Console.Write(row % 2);
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */

            //Pattern Programming-5
            //A B C D E
            //A B C D
            //A B C
            //A B
            //A
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
            {
                for (col = row; col >= 1; col--)
                {
                    Console.Write((char)(col + 64));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-6
            //E E E E E
            //D D D D
            //C C C
            //B B
            //A
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
            {
                for (col = row; col >= 1; col--)
                {
                    Console.Write((char)(row + 64));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-7
            //a b c d e
            //a b c d
            //a b c
            //a b
            //a
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
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
            //e e e e e
            //d d d d
            //c c c
            //b b
            //a
            /*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
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
            //* * * * *
            //* * * *
            //* * *
            //* *
            //*
            ///*
            int n = 5, row, col;

            for (row = n; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            //*/
        }
    }
}

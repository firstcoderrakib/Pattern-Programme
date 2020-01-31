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
            //Pattern Programming-1
            //1 
            //1 2
            //1 2 3 
            //1 2 3 4 
            //1 2 3 4 5 
            //1 2 3 4
            //1 2 3 
            //1 2
            //1
            /*
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
                */

            //Pattern Programming-1
            //1 
            //2 2
            //3 3 3 
            //4 4 4 4 
            //5 5 5 5 5 
            //4 4 4 4
            //3 3 3 
            //2 2
            //1
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
                for (row = n - 1; row >= 1; row--)
                {
                    for (col = 1; col <= row; col++)
                    {
                        Console.Write(row);
                    }

                    Console.WriteLine("\n");
                }
                Console.ReadKey();
            */
            //Pattern Programming-1
            //A 
            //A B
            //A B C 
            //A B C D 
            //A B C D E 
            //A B C D 
            //A B C 
            //A B 
            //A
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
            for (row = n - 1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(col + 64));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-1
            //A 
            //B B
            //C C C 
            //D D D D 
            //E E E E E 
            //D D D D 
            //C C C 
            //B B 
            //A
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
            for (row = n - 1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(row + 64));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-1
            //a
            //b b 
            //c c c
            //d d d d
            //e e e e e
            //d d d d
            //c c c 
            //b b 
            //a
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
            for (row = n - 1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(col + 96));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-1
            //a
            //a b 
            //a b c
            //a b c d
            //a b c d e
            //a b c d
            //a b c 
            //a b 
            //a
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
            for (row = n - 1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write((char)(col + 96));
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-1
            //#
            //# #
            //# # #
            //# # # #
            //# # # # #
            //# # # #
            //# # #
            //# # 
            //#
            /*
            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("#");
                }

                Console.WriteLine("\n");
            }
            for (row = n - 1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("#");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
            */
            //Pattern Programming-1
            //*
            //* * 
            //* * * 
            //* * * *
            //* * * * *
            //* * * 
            //* * 
            //*

            int n = 5, row, col;

            for (row = 1; row <= n; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
            for (row = n - 1; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

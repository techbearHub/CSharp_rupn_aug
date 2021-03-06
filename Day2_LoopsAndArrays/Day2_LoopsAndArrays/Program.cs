﻿using System;

namespace Day2_LoopsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySample();
        }

        private static void ArraySample()
        {
            int[] a = new int[5];

            int b = Convert.ToInt32(Console.ReadLine());
            a[0] = 99;
            a[1] = 99;
            a[2] = 99;
            a[3] = 99;
            a[4] = 99;

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = 99;
            }
        }

        static void Task2()
        {
            String result = "";

            for(int i = 0; i < 4; i++)
            {
                result += "*";
                Console.WriteLine(result);
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Task1()
        {
            Random rand = new Random();
            int biggest = 0;

            for(int i = 0; i < 10; i++)
            {
                int randNumber = rand.Next(60);

                if(randNumber > biggest)
                {
                    biggest = randNumber;
                }
            }

            Console.WriteLine(biggest);
        }


        static void Task1Extra()
        {
            Console.WriteLine("ievadiet skaitli!");
            int biggest = Convert.ToInt32(Console.ReadLine()); ;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("ievadiet skaitli!");
                int randNumber = Convert.ToInt32(Console.ReadLine());

                if (randNumber > biggest)
                {
                    biggest = randNumber;
                }
            }

            Console.WriteLine(biggest);
        }

        static void RandomSample()
        {
            Random rand = new Random();
            int a = rand.Next(60);
        }
    }
}

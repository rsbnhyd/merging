﻿using System;

namespace merging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to C#!");

            Console.WriteLine("Commit 1 Master!");
            Console.WriteLine("Commit 2 Master!");

            Console.WriteLine("Commit 1 on my-local");
            Console.WriteLine("Commit 2 on my-local");
            /* Feature1 */
            Console.WriteLine("Feature 1 on Feature");
            //commit 2
            Console.WriteLine("Feature 1 on Feature");
            //commit 3
            Console.WriteLine("Feature 1 on Feature");

            for (int i = 0; i < 10; i++)
            {

                for (int j = i; j > 0; j--)
                {
                    System.Console.Write(j);
                }
                System.Console.WriteLine();
            }

            /*Feature2*/
            Console.WriteLine("Commit1 on Feature2");

            Console.WriteLine("Commit2 on Feature2");

            Console.WriteLine("Commit3 on Feature2");

            Console.WriteLine("Commit4 on Feature2");

            //FEATURE3
            Console.WriteLine("Commit  on Feature3 branch");

            Console.WriteLine("Commit 2 on Feature3 branch");

            Console.WriteLine("Commit 3 on Feature3 branch");

        }
    }
}

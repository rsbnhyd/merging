using System;

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

            /*Feature2*/
            Console.WriteLine("Commit1 on Feature2");

            Console.WriteLine("Commit2 on Feature2");

            Console.WriteLine("Commit3 on Feature2");

            Console.WriteLine("Commit4 on Feature2");

        }
    }
}

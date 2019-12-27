using System;

namespace Basic_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintingGitForNthIteration();
            PrintCollection();

        }

        private static void PrintCollection()
        {
            string[] users = {"Jon", "Mary", "Tom", "Reddington", "Anderson"};
            Console.WriteLine("-----------Using for each---------------");
            foreach (var item in users)
            {
                Console.WriteLine(item);   
            }

            Console.WriteLine("-------------Using classical for--------------");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
        }

        /// <summary>
        /// Iteration based on user input,
        /// </summary>
        private static void PrintingGitForNthIteration()
        {
            Console.WriteLine("Hello World! here i am Git"); //CW is the shorcut for Console.WriteLine
            Console.WriteLine("Please enter the number of times you want to print 'Git'");
            string strValPrintGit = Console.ReadLine();
            Console.WriteLine("Would you like to print each git in new line or in same line[y/n]");
            var decisionToPrint = Console.ReadKey();
            Console.WriteLine();
            int nTimesGit = 0;
            int.TryParse(strValPrintGit, out nTimesGit);

            for (int i = 0; i < nTimesGit; i++)
            {
                if (decisionToPrint.Key == ConsoleKey.Y)
                    Console.WriteLine("Git");
                else
                {
                    Console.Write("Git");
                }
            }
        }
    }
}

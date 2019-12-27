using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! here i am Git");//CW is the shorcut for Console.WriteLine
            Console.WriteLine("Please enter the number of times you want to print 'Git'");
            string strValPrintGit = Console.ReadLine();
            Console.WriteLine("Would you like to print each git in new line or in same line[y/n]");
            var decisionToPrint = Console.ReadKey();
            Console.WriteLine();
            int nTimesGit = 0;
            int.TryParse(strValPrintGit, out nTimesGit);

            for (int i = 0; i < nTimesGit; i++)
            {
                if(decisionToPrint.Key == ConsoleKey.Y)
                    Console.WriteLine("Git");
                else
                {
                    Console.Write("Git");
                }
            }

        }
    }
}

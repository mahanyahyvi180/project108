using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp94
{
    class Program
    {
        static void Main(string[] args)
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;

            while (studentCounter <= 10)
            {
                Console.Write("Enter result(1=pass,2=fail):");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    passes = passes + 1;
                }
                else
                {
                    failures = failures + 1;
                }
                studentCounter = studentCounter + 1;
            }

            Console.WriteLine($"passed:{passes}\nFailed:{failures}");

            if (passes > 8)
            {
                Console.WriteLine("WINE");
                Console.ReadLine();
            }
        }
    }
}

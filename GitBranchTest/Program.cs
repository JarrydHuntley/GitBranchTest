using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBranchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            for (int i = 3; i < 20; i++)
            {
                Console.WriteLine("This is the branch where everything is fixed for REAL!" + i);
            }

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(" Numbers: " + i);
            }

        }
    }
}

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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Git branch test yay " + i);
            }

        }
    }
}

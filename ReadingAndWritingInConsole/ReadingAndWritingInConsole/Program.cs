using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingAndWritingInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Please Enter The Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("hello " + userName);
            Console.WriteLine("hello {0} {1}" , userName , LastName);
            Console.ReadLine();
        }
    }
}

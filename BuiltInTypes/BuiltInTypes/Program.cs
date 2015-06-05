using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            Console.WriteLine("this is a boolean value "+b);
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
            double d = 123.1231241;
            Console.WriteLine("decimal number = "+d );
            string name = "\"Surajit\nBarman\"";
            Console.WriteLine(name);
            string sequenceExample = @"C:\\program\\hello";
            Console.WriteLine(sequenceExample);
            Console.ReadLine();

        }
    }
}

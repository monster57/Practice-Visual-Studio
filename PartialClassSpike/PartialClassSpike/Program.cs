using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassSpike
{
    class Program
    {
        static void Main(string[] args)
        {
               Employee employee = new Employee(){employeeId = 1 , name = "E1" , Salary = 100000};
            Console.WriteLine(employee.ToString());
            Console.ReadLine();
        }
    }
}

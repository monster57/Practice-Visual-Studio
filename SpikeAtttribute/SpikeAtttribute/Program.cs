using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpikeAtttribute
{
    class Program
    {
       
        static void Main(string[] args)
        {
//            var testSuite =
//                from t in Assembly.GetExecutingAssembly().GetTypes()
//                where t.GetCustomAttributes().Any(a => a is TestAttribute)
//                select t;
//
//            foreach (Type type in testSuite)
//            {
//                Console.WriteLine("Running Test in Suite  "+type.Name);
//                var testMethod =
//                    from m in type.GetMethods()
//                    where m.GetCustomAttributes(false).Any(a => a is TestMethodAttribute) 
//                    select m;
//                object testSuiteInstance = Activator.CreateInstance(type);
//                foreach (MethodInfo info in testMethod)
//                {
//                    info.Invoke(testSuiteInstance, new object[0]);
//                }
//            }
            Guid guid;
            guid = Guid.NewGuid();
            Console.WriteLine(guid);
            Console.WriteLine(Guid.NewGuid());
            Console.ReadLine();
        }

        
    }
}

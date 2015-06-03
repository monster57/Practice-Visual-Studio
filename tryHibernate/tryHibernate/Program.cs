using System;
using System.Linq;
using System.Threading;
using NHibernate;

namespace tryHibernate
{
    public class Program
    {

        public static void Main()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            
            IQuery query = session.CreateQuery("SELECT sd FROM Student sd");

            while (true)
            {
                foreach (Student student in query.List<Student>())
                {
                    Console.Out.WriteLine("Student First name: " + student.FirstName);
                    Console.WriteLine(String.Join(",", student.Subjects.Select(sub => sub.Name).ToArray()));
                }
                //Thread.Sleep(600);
            }
            return;
        }
    }
}

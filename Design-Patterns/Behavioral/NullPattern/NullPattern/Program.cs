using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = StudentFactory.GetstudentDetails("Mahesh");
            Console.WriteLine(student1.GetStudentName());

            Student student2 = StudentFactory.GetstudentDetails("Rohit");
            Console.WriteLine(student2.GetStudentName());

            Console.Read();
        }
    }
}

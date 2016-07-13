using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern
{
    public class StudentFactory
    {
        public static string[] studentNames = { "Mahesh", "Rakesh", "Rajesh" };

        public static Student GetstudentDetails(string name)
        { 
            foreach(string stdName in studentNames)
            {
                if(string.Compare(stdName,name,true) == 0)
                {
                    return new RealStudent(name);
                }
            }
            return new NullStudent();
        }
    }
}

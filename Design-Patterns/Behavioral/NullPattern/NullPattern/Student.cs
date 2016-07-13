using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern
{
    public abstract class Student
    {
        public string studentName;
        public abstract bool IsNull();
        public abstract string GetStudentName();
    }
}

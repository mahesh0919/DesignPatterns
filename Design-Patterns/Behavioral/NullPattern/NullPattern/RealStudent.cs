using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern
{
    public class RealStudent : Student
    {
        public RealStudent(string name)
        {
            this.studentName = name;
        }

        public override string GetStudentName()
        {
            return studentName;
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPattern
{
    public class NullStudent : Student
    {
        public override string GetStudentName()
        {
            return "Student Not Available";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}

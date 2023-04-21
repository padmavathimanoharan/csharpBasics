using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Student
    {
        public string name;
        public string dept;
        public double gpa;

        public Student(string aName, string aDept, double aGpa)
        {
            name = aName;
            dept = aDept;
            gpa = aGpa;
        }

        // ObjectMethods
        public bool Honors()
        {
            if(gpa > 3.0)
            {
                return true;
            }
            return false;
        }
    }
}

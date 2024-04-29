using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask28
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Student(string firstName, string lastName, byte age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}

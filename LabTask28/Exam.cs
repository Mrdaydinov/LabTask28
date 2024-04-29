using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask28
{
    internal class Exam
    {
        public Student Student { get; set; }
        public byte Point { get; set; }
        public string Subject { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Exam(byte point, string subject, DateTime starDate, DateTime endDate, Student student)
        {
            Point = point;
            Subject = subject;
            StartDate = starDate;
            EndDate = endDate;
            Student = student;
        }

        public void IsPassed()
        {
            if (Point > 50)
                Console.WriteLine($"Student: {Student.FirstName} - Subject {Subject} passed");
            else
                Console.WriteLine($"Student: {Student.FirstName} - Subject {Subject} not passed");
        }

        public void LongerThanHour()
        {
            if (EndDate - StartDate > new TimeSpan(1, 0, 0))
            {
                Console.WriteLine($"Student {Student.FirstName} - Subject {Subject} exam time more than 1 hour");
            }
            else
                Console.WriteLine($"Student {Student.FirstName} - Subject {Subject} exam time less than 1 hour");
        }
    }
}

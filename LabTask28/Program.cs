using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;

namespace LabTask28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count of exams");
            int count = int.Parse(Console.ReadLine());


            List<Exam> list = new List<Exam>();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Point");
                var point = byte.Parse(Console.ReadLine());
                Console.WriteLine("Subject");
                var subject = Console.ReadLine();
                Console.WriteLine("StartDate");
                var startDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("EndDate");
                var endDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Student firstName");
                var firstname = Console.ReadLine();
                Console.WriteLine("Student lastName");
                var lastName = Console.ReadLine();
                Console.WriteLine("Student Age");
                var age = byte.Parse(Console.ReadLine());

                list.Add(new Exam(point, subject, startDate, endDate, new Student(firstname, lastName, age)));

            }

            foreach (Exam exam in list)
            {
                exam.IsPassed();
                exam.LongerThanHour();
            }
        }
    }
}

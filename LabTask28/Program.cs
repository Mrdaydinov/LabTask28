namespace LabTask28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());


            List<Exam> list = new List<Exam>();
            for (int i = 0; i < count; i++)
            {
                list.Add(
                    new Exam(byte.Parse(Console.ReadLine()), Console.ReadLine(), DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()), new Student(Console.ReadLine(), Console.ReadLine(), byte.Parse(Console.ReadLine())))
                         );
            }

            foreach (Exam exam in list)
            {
                exam.IsPassed();
                exam.LongerThanHour();
            }
        }
    }
}

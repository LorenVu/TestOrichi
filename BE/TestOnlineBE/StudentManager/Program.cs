using StudentManager.Algothims;
using StudentManager.Entities;
using StudentManager.Enums;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = MockStudentData();
            PrintData(students);

            Console.WriteLine("-------------------------------");

            students.Sort(0, students.Count() - 1);
            PrintData(students);
        }

        private static void PrintData(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.AverageScore}");
            }
        }

        static List<Student> MockStudentData()
        {
            var random = new Random();

            return [
                new Student("Nguyen Van A", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Doan Hai T", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Ngo Thi H", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Phong Linh N", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Tran Ha V", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Nguyen Xuan M", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Van Quoc Khanh", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Nan Hung R", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
                new Student("Moc Thi D", new Dictionary<string, int>
                {
                    { Subjects.Math, random.Next(0, 10) },
                    { Subjects.Physic, random.Next(0, 10) },
                    { Subjects.Chemistry, random.Next(0, 10) }
                }),
            ];
        }
    }
}

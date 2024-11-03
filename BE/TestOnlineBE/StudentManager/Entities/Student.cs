namespace StudentManager.Entities
{
    public class Student
    {
        public Student(string name, Dictionary<string, int> scores)
        {
            Name = name;
            Scores = scores;
            AverageScore = Scores.Values.Average();
        }

        public string Name { get; init; }
        public Dictionary<string, int> Scores { get; set; } = new Dictionary<string, int>();
        public double AverageScore { get; private set; }
    }
}

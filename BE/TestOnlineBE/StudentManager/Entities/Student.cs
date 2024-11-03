namespace StudentManager.Entities
{
    public class Student
    {
        public Student(string name, Dictionary<string, int> scores)
        {
            Name = name;
            Scores = scores;
            AverageScore = Scores.Count != 0 ? Math.Round(Scores.Values.Average(), 1) : 0.0;
        }

        public string Name { get; init; }
        public Dictionary<string, int> Scores { get; set; } = [];
        public double AverageScore { get; private set; }
    }
}

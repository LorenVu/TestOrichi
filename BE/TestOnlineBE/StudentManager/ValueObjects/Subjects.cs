namespace StudentManager.Enums
{
    internal record Subjects(string Name)
    {
        public static string Math { get; } = "Math";
        public static string Physic { get; } = "Physic";
        public static string Chemistry { get; } = "Chemistry";
    }
}

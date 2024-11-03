namespace StudentManager.Enums
{
    internal record Subjects(string Name)
    {
        public static string Math { get; } = new("Math");
        public static string Physic { get; } = new("Physic");
        public static string Chemistry { get; } = new("Chemistry");
    }
}

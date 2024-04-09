namespace DesingPatterns
{
    internal class DesingPatternsExample
    {
        public List<(string Name, Action ExampleImplementation)> Examples { get; set; } = [];

        internal void Run()
        {
            foreach (var (Name, ExampleImplementation) in Examples)
            {
                ConsoleTemplate.LogExercise(Name);

                ExampleImplementation();

                ConsoleTemplate.EndOfTheLine();
            }
        }
    }

}

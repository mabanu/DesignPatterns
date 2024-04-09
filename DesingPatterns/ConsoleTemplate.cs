namespace DesingPatterns
{
    internal static class ConsoleTemplate
    {
        internal static void CreateTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Create a separator line
            string separator = new string('=', Console.WindowWidth);

            // Calculate padding for center alignment
            int padding = (Console.WindowWidth - title.Length - 6) / 2;

            // Print the centered title with separators
            Console.WriteLine(separator);
            Console.WriteLine($"|{new string(' ', padding)}{title}{new string(' ', padding)}|");
            Console.WriteLine(separator);

            // Reset console text color
            Console.ResetColor();
        }

        internal static void LogExercise(string name)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            // Calculate padding for center alignment
            int padding = (Console.WindowWidth - name.Length - 6) / 2;

            // Print the centered title with separators
            Console.WriteLine($"|{new string('-', padding)}{name}{new string('-', padding)}|");

            // Reset console text color
            Console.ResetColor();
        }

        internal static void EndOfTheLine()
        {
            Console.WriteLine("\n");
        }
    }
}

using Functional;
using static Functional.Bind.Parse;
using static System.Console;

namespace CLI
{
    public static class Program
    {
        public static void Main()
        {
            WriteLine($"Only {ReadAge().Value}! That's young!");
            ReadKey();
        }

        private static string Prompt(string prompt)
        {
            WriteLine(prompt);
            return ReadLine();
        }

        private static Age ReadAge()
            => ParseAge(Prompt("Pleae enter your age")).Match(ReadAge, age => age);
    }
}
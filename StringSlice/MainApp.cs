using System;
using static System.Console;

namespace StringSlice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            WriteLine(greeting.Substring(0, 5)); // "Good"
            WriteLine(greeting.Substring(5)); // "morning"
            WriteLine();

            string[] arr = greeting.Split(
                new string[] {" "}, StringSplitOptions.None);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}

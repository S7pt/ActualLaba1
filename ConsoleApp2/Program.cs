using System;

namespace ConsoleApp2
{
    public class Program
    {
        static public int Counter(int seconds)
        {
            int minutes = seconds / 60;
            return minutes;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type seconds to convert");
            string seconds = Console.ReadLine();
            int result = Counter(int.Parse(seconds));
            Console.WriteLine(result + " minutes have passed");
        }
    }
}

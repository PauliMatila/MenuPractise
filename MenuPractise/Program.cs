using System;
using System.Drawing;
using System.Net.Http;

namespace MenuPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Reverse String");
            Console.WriteLine("2. Replace Whitespace with _");
            Console.WriteLine("3. Create Person");
            Console.WriteLine("4. ");
            Console.WriteLine("3. Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    ReplaceWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void ReplaceWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Replace Whitespace");
            DisplayResult(CaptureInput().Replace(" ", "_"));
        }
        


        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}

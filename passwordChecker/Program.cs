using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQURSTUVWXYZ";
            string lowercase = "abcdefghijkllmnopqurstuvwxyz";
            string digits = "1234567890";
            string specialChars = "~!@#$%^&*-+";
            Console.WriteLine("Please input your password.");
            string userPass = Console.ReadLine();
            int score = 0;

            if (userPass.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(userPass, uppercase))
            {
                score++;
            }
            if (Tools.Contains(userPass, lowercase))
            {
                score++;
            }
            if (Tools.Contains(userPass, digits))
            {
                score++;
            }
            if (Tools.Contains(userPass, specialChars))
            {
                score++;
            }
            if (score == 1)
            {
                Console.WriteLine("Weak.");
            }
            else if (score == 2)
            {
                Console.WriteLine("Medium");
            }
            else if (score == 3)
            {
                Console.WriteLine("Strong.");
            }
            else if (score == 4)
            {
                Console.WriteLine("Extreamely strong!");
            }
            else if (score == 5)
            {
                Console.WriteLine("Extreamly strong again!");
            }
            else if (score == 0)
            {
                Console.WriteLine("It’s a bunch of spaces…It doesn’t meet any of the standards.");
            }
            Console.WriteLine(score);
            Console.ReadKey();
            // Could not find Tools.cs file
        }
    }
}

using System;

namespace password_homework

{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            Console.WriteLine("Please enter your strong passsword of minimum length 8: ");
            string passwordUser = Console.ReadLine();
            int score = 0;
            if ((passwordUser == "password") || (passwordUser == "1234"))
            {
                Console.WriteLine("!!! WEEK PASSWORD TRY AGAIN !!!");
                Console.WriteLine("Please enter your strong passsword of minimum length 8: ");
                passwordUser = Console.ReadLine();
            }
            else
            {

                if (passwordUser.Length >= minLength)
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, upperCase))
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, lowerCase))
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, digits))
                {
                    score++;
                }
                if (Tools.Contains(passwordUser, specialChars))
                {
                    score++;
                }

            }
            Console.WriteLine(score);

            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("Your password is extremely strong");
                    break;

                case 3:
                    Console.WriteLine("Your password is strong");
                    break;

                case 2:
                    Console.WriteLine("Your password is medium");
                    break;

                case 1:
                    Console.WriteLine("Your password is week");
                    break;

                default:
                    Console.WriteLine("Your password doesn't meet any standards");
                    break;
            }
        }
    }

    internal class Tools
    {
        internal static bool Contains(string passwordUser, string digits)
        {
            throw new NotImplementedException();
        }
    }
}
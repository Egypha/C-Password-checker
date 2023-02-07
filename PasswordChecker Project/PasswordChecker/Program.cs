using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Defining the specifications for the checks
            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTWXYZ";
            string lowerCase = "abcdefghijklmnopqrstwxyz";
            string digits = "0123456789";
            string specialChars = "!£$%^&*(),./;#[]{}-_=+|";
            Console.WriteLine("Please enter your password for rating...");
            //Getting the user to input password
            string password = Console.ReadLine();
            int leng = password.Length;
            int score = 0;
            //Ranking the password by checking against the specifications
            if (leng >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, upperCase))
            {
                score++;
            }
            if (Tools.Contains(password, lowerCase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            //Output for the rank of users password
            Console.WriteLine(score);
            //Pause to allow user to see rank
            Console.ReadKey();
        }
    }
}

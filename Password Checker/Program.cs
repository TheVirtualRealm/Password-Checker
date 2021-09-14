using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*-+";

            Console.Write("Enter a your password: ");
            string password = Console.ReadLine();
            Console.WriteLine(password);

            int score = 0;
            if (password.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
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

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Great Password");
                    break;
                case 3:
                    Console.WriteLine("Decent password");
                    break;
                case 2:
                    Console.WriteLine("Could use some work");
                    break;
                case 1:
                    Console.WriteLine("Weak Password");
                    break;
                default:
                    Console.WriteLine("Password does not meet the requirments");
                    break;


            }
        }
}

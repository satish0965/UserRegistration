using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {
        public static void ValidEmail()
        {
            Console.WriteLine("Enter Email");
            string data  = Console.ReadLine();
            //satish.patil@gmail.com
            //satish.patil@gmail.co.in
            string namepattern = "^[a-zA-Z]+[,+-]+[0-9a-zA-Z]+[@]+[a-zA-Z]+[.]+[a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            Regex regex = new Regex(namepattern);
            if(regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email is not Valid");
                Console.ResetColor();

            }
        }
    }
}

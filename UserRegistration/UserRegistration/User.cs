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
        public static void ValidLastName()
        {
            Console.WriteLine("Enter LastName");
            string data  = Console.ReadLine();
            string namepattern = "^[A-Z]{1},[a-zA-Z]{2,}";
            Regex regex = new Regex(namepattern);
            if(regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Name is not Valid");
                Console.ResetColor();

            }
        }
    }
}

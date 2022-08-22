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
        public static void PassWorldRule3()
        {
            Console.WriteLine("Enter PassWord");
            string data  = Console.ReadLine();
            string namepattern = "^[A-Za-z]{8,}[A-Z]{1,}[0-9]{1,}$";
            Regex regex = new Regex(namepattern);
            if(regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PassWord is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PassWord is not Valid");
                Console.ResetColor();

            }
        }
    }
}

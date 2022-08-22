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
        public static void PassWorldRule1()
        {
            Console.WriteLine("Enter PassWord");
            string data  = Console.ReadLine();
            string namepattern = "^[a-zA-z0-9]{8,16}$";
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

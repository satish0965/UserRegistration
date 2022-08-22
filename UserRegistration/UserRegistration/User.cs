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
        public static void MobileNumber()
        {
            Console.WriteLine("Enter Mobile Number");
            string data  = Console.ReadLine();
            string namepattern = "^[1-9][0-9][ ]{1}[6-9][0-9]{9}$";
            Regex regex = new Regex(namepattern);
            if(regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mobile Number is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mobile Number is not Valid");
                Console.ResetColor();

            }
        }
    }
}

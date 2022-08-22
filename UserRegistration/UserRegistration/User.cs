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
        public static void EmailSample()
        {
            Console.WriteLine("Enter Email");
            string data  = Console.ReadLine();
             //Valid Emails
             //abc@yahoo.com
             //abc - 100@yahoo.com
             //abc.100@yahoo.com
             //abc111@abc.com
             //abc - 100@abc.net
             //abc.100@abc.com.au
             //abc@1.com
             //abc@gmail.com.com
             //abc + 100@gmail.com
            string namepattern = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$";
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

using System;
using System.Linq;

namespace password_del1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please create a password with the following requirements:");
            Console.WriteLine("Contains at least one lowercase letter");
            Console.WriteLine("Contains at least one uppercase letter");
            Console.WriteLine("Contains a minimum of 7 characters");
            Console.WriteLine("Contains a maximum of 12 characters");
            Console.WriteLine("Contains an exclamation point: !");
            Console.WriteLine("Enter your new password: ");
            string pword = Console.ReadLine();
            //Console.WriteLine("You entered:  " + pword);
            if (pword.Any(char.IsLower) &&
                pword.Any(char.IsUpper) &&
                pword.Contains("!") &&
                pword.Length >= 7 && pword.Length <= 12)
              { Console.WriteLine("Password valid and acccepted"); }
            else
               Console.WriteLine("error");


        }
    }
}

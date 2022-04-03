using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User password = new User("Mehemmed","magamed.djafarov@gmail.com","Maqa5165");
            
            if (password.PasswordChecker(password.Password))
            {
                Console.WriteLine("dogru");
            }
            else
            {
                Console.WriteLine("false");
            }
            
        }
    }
}

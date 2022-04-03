using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User : IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;

        public User(string Fullname, string Email, string Password)
        {
            this.Fullname = Fullname;
            this.Email = Email;
            this.Password = Password;

        }

        public bool PasswordChecker(string password)
        {
            int length = password.Length;
            bool stringLength = length >= 8;
            bool upperCaseIsExist = false;
            bool lowerCaseIsExist = false;
            bool numberIsExist = false;


          
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i]))
                {
                    upperCaseIsExist = true;
                    
                }
                if (Char.IsLower(password[i]))
                {
                    lowerCaseIsExist = true;
                }
                if (Char.IsNumber(password[i]))
                {
                    numberIsExist = true;
                }
            }
            if (stringLength && upperCaseIsExist && lowerCaseIsExist && numberIsExist)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public void ShowInfo()
        {
            Console.WriteLine(Fullname,Email);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
     
    }
}

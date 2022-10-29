using System;
using System.Collections.Generic;
using System.Text;

namespace SolidWithC_Sharp
{
    // Note: Do not declare all method in a single interface.
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }

    interface ILoger
    {
        void LogError(string error);
        bool Register(string username, string password, string email);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}

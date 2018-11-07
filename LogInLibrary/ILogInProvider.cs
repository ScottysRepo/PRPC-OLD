using System;

namespace LogInLibrary
{
    interface ILogInProvider
    {
        string PasswordVerify(string password);
    }
}
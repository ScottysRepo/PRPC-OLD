using System;
using LogInLibrary; 


namespace LogInClient
{
    class Program
    {
        static void Main(string)
        {
            LogInProvider provider = new LogInProvider();
            Console.WriteLine(LogInProvider.PasswordVerify("abc123"));
            Console.WriteLine("Hello World!");
            //Console.WriteLine(PRPC.Method());
        }
    }
}

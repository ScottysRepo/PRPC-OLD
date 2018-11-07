using System;
using LogInLibrary; 


namespace LogInClient
{
    class Program
    {
        static void Main(string [] args)
        {
            LogInProvider provider = new LogInProvider();
            Console.WriteLine("Please enter password");
           // string inputtedPassword = Console.ReadLine();
            Console.WriteLine(LogInProvider.PasswordVerify('abc123'));
            Console.WriteLine("Hello World!");
            //Console.WriteLine(PRPC.Method());
        }
    }
}

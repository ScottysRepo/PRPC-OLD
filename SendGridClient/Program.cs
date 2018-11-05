using System;
using SendGridLib;

namespace SMTPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SendGrid SMTP = new SendGrid();
            Console.WriteLine("Hello World");
        }
    }
}

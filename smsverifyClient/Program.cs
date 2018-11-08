using System;
using smsverifylibrary;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using dotenv.net;
using System.Threading.Tasks;
namespace smsverifyClient
{
    class Program 
    {
        public static string PhoneNumber= "+18065498221";
        public static string TwilioNumber = "+18064244476";
        static void Main(string[] args)
        {

            DotEnv.Config();

            // Find your Account Sid and Token at twilio.com/console
            string accountSID = System.Environment.GetEnvironmentVariable("TWILIO_SID");
            string authToken = System.Environment.GetEnvironmentVariable("TWILIO_AUTHTOKEN");
            
            Console.WriteLine($"auth token is: {authToken}");
            Console.WriteLine($"accout_sid is: {accountSID}");

            Console.WriteLine($"Phone number is: {PhoneNumber}");
            try
            {
                
                TwilioClient.Init(accountSID, authToken);
                

                var message = MessageResource.Create(
                    body: "This is the ship that made the Kessel Run in fourteen parsecs?",
                    from: new Twilio.Types.PhoneNumber(TwilioNumber),
                    to: new Twilio.Types.PhoneNumber(PhoneNumber)
                );

                Console.WriteLine(message.Sid);

                Console.WriteLine(message.AccountSid);
            }
            catch(Exception exp)
            {
                Console.Error.WriteLine("Error:" + exp.Message + Environment.NewLine + " " + exp.StackTrace);
            }
        }
    }
}


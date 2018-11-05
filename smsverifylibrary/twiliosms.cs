using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using dotenv;

namespace smsverifylibrary
{

    interface ISmSVerify
        {
            string NumberToText(string PhoneNumber);
        }

    //Add :ISmSVerify eventually
    public class TwilioSmS
{
    public string PhoneNumber = "1234567890"
    void Main(string[] args)
    {
        //RecPhone is placeholder for the Model.Phone we will need to send to each phone that is registered
        SendSms(PhoneNumber).Wait();
        Console.Write("Press any key to continue.");
        Console.ReadKey();
    }

    async Task SendSms(string PhoneNumber)
    {
        // Need to figure out how to call those .env variables.
        const string accountSid = Environment.GetEnvironmentVariable(TWILIO_SID);
        const string authToken = Environment.GetEnvironmentVariable(TWILIO_AUTHTOKEN);

        TwilioClient.Init(accountSid, authToken);

        var message = await MessageResource.CreateAsync(
            body: "Would you like to recieve text notifications? Please reply Yes or No.",
            from: new Twilio.Types.PhoneNumber("+18064244476"),
            to: new Twilio.Types.PhoneNumber(RecPhone)
        );

        Console.WriteLine(message.Sid);
    }
}
}

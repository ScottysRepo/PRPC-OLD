using System;
using smsverifylibrary;

namespace smsverifyClient
{
    class Program
    {
        public class TwilioSmS
{
    public string PhoneNumber = "8065498221";
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
        //const string accountSid = System.Environment.GetEnvironmentVariable(TWILIO_SID);
        //const string authToken = System.Environment.GetEnvironmentVariable(TWILIO_AUTHTOKEN);
        const string accountSid ="";
        const string authToken = "";

        TwilioClient.Init(accountSid, authToken);

        var message = await MessageResource.CreateAsync(
            body: "Would you like to recieve text notifications? Please reply Yes or No.",
            from: new Twilio.Types.PhoneNumber("+18064244476"),
            to: new Twilio.Types.PhoneNumber(PhoneNumber)
        );

        Console.WriteLine(message.Sid);
    }
}
    }
}

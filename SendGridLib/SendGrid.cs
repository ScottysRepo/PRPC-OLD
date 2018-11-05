using System;
using SendGrid.Helpers.Mail;
using SendGrid;
using System.Threading.Tasks;


namespace SendGridLib
{
     interface ISMTP
    {
       Execute(msg);
    }
     public class SendGrid : ISMTP
    {
        private static void Main()
        {
            Execute().Wait();
        }
    public async Task Execute()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage();
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Verification Email";
            var to = new EmailAddress();
            var plainTextContent = "Please click on the link";
            var htmlContent = "<strong>Please click on the link</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        
    }

}
}

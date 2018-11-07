using SendGrid.Helpers.Mail;
using SendGrid;
using System.Threading.Tasks;


namespace SendGridLib
{
    interface ISMTP
    {
        string EmailConfirmation (string ConfSent);
    }  
     public class EmailConf : ISMTP 
    {
        public string EmailConfirmation(string ConfSent)
        {
            private readonly SendGridClient _client;

            public EmailConf()
            {
            // Retrieve the API key from an appSettings variable from the web.config
                var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");

            // Initialize the SendGrid client
                _client = new SendGridClient(apiKey);
            }

            public async Task<Response> Send(EmailMessageInfo messageInfo)
            {
            // Prepare the SendGrid email message
                var sendgridMessage = new SendGridMessage
                {
                    From = new EmailAddress(messageInfo.FromEmailAddress),
                    Subject = messageInfo.EmailSubject,
                    HtmlContent = messageInfo.EmailBody
                };

            var response = await _client.SendEmailAsync(sendgridMessage);

            return response;
            }
        }
           
    }
}

    
            
        
    





        /* public string EmailConfirmation(string ConfSent)
        {
            void Main()
            {
                Execute().Wait();
            }

            async Task Execute()
            {
            
            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("test@example.com", "DX Team"),
                Subject = "Hello World from the SendGrid CSharp SDK!",
                PlainTextContent = "Hello, Email!",
                HtmlContent = "<strong>Hello, Email!</strong>"
            };
            msg.AddTo(new EmailAddress("troyreeves2@gmail.com", "Test User"));
            var response = await client.SendEmailAsync(msg);
        }
        }*/
   
 
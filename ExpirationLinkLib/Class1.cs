using System.Threading.Tasks;


namespace ExpirationLinkLib
{
    public class AuthMessageSenderOptions
    {
        public string SendGridUser {get;set;}

        public string SendGridKey {get;set;}
    }
    
    interface IEmailSender{

    }
    public class EmailSender : IEmailSender
    {
        public async Task  ConfirmEmail(string userId, DateTime date, string code)
      {
          if (userId == null )
          {
              return NotFound();
          }

          var user = await _context.FindByIdAsync(userId);
          if (user == null || date != null)
          { 
            if (date.AddMinutes(1)<DateTime.Now)
              {
                  return RedirectToAction("Confirmation Link has Expired");
              }
              else 
              {
                  var result = await _context.ConfirmEmailAsync(user);
                  return View(result.Succeded);
              }
          }
          else
          {
              return View("Error");
          }
      }
    }
        
}

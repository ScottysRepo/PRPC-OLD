using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExpirationClient.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace ExpirationClient.Controllers
{
    [RequireHttps]
    [Route("api/[controller]")]
    public class NotifController : Controller
    {
        private readonly IConfiguration _configuration;

        private readonly EmailNewRiderdb _context;

        public NotifController(IConfiguration configuration)
       {
         _configuration = configuration;
       }

       public NotifController(EmailNewRiderdb context)
        {
            _context = context;
        }

        public async Task <IActionResult> ConfirmEmail(string userId, DateTime date, string code)
      {
          if (userId == null )
          {
              return NotFound();
          }

          var user = await _context.FindByIdAsync(userId);
          var sentDate = _context.FindByAsync (daterecordId);
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
   
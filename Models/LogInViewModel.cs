using System;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

using LogInClient;
using LogInLibrary;

namespace LogInClient.Models
{

    public class LogIn
    {

        [Required()]
        public string username { get; set;}

        [DataType(DataType.Password)]
       
        [Required()]
        
        public string password { get; set;}
         

        

      
   }
}
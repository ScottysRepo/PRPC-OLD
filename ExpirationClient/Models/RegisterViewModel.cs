using System;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace PRPC_CIDM4390.Models
{

    public class Register
    {

        [Required()]
        public string username { get; set;}

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required()]
        
        public string password { get; set;}
        [Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 8)]
        [Required()]
    
        public string confirmpassword {get; set;}


        public string firstname {get; set;}

        public string lastname {get; set;}

        public string birthday {get; set;}

        [DataType(DataType.EmailAddress)]
        [StringLength(128)]
        [Required()]
        public string EmailAddress {get; set;}
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{8}$")]
        [StringLength(32)]
        public string phonenumber {get; set;}
   }
}
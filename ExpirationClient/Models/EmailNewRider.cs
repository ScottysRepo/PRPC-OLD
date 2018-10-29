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
 public class Rider
    {
        private int _userId;

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public int userId { get => _userId; set => _userId = value; }

        public DateTime daterecordId {get; set;}
    }
}
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monolith.Schedule.Data
{
    public class MyUser : IdentityUser
    {
        //public int Id { get; set; }
        public string? Name { get; set; }
        //public string Username { get; set; }
        public string? Passwor { get; set; }
    }
}

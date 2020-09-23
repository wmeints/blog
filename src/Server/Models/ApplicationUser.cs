using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ProfileImage { get; set; }
        public string Biography { get; set; }
        public string TwitterAccount { get; set; }
        public string LinkedInAccount { get; set; }
    }
}

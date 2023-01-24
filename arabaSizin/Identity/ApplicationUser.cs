using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace arabaSizin.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string name { get; set; }
        public string surname { get; set; }
    }
}
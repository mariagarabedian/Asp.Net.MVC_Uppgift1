using Asp.Net.MVC_Uppgift1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net.MVC_Uppgift1.Models
{
    public class CreateUserViewModel : AppUser
    {
        public string Password { get; set; }
    }
}

using Asp.Net.MVC_Uppgift1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net.MVC_Uppgift1.Models
{
    public class EditClassesViewModel
    {

        public SchoolClass CurrentClass { get; set; }
        public IEnumerable<AppUser> Teachers { get; set; }
        public IEnumerable<AppUser> Students { get; set; }

    }
}

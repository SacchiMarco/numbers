using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace numbers.Models
{
    public class ApplicationUser : IdentityUser
    {   
        [ForeignKey("UserId")]
        public virtual UserAdress UserAdress { get; set; }
    }

    
}

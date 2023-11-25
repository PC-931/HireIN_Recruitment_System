using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechM.RecruitmentSystem.Entity
{
    public class User : IdentityUser 
    {
        public bool IsAgency { get; set; } = false;
        [Required]
        public string Password {  get; set; }
    }
}

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.DataService
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext() : base("DBConn") 
        {
            
        }

        public DbSet<Vacancy> Vacancies { get; set; }

        public DbSet<Applicant> Applicants { get; set; }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechM.RecruitmentSystem.Entity
{
    public class Vacancy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public decimal Salary { get; set; }

        public User User { get; set; }

    }
}

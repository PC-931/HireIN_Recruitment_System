using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechM.RecruitmentSystem.Entity
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid Guid { get; set; }
        public User UserId { get; set; }
        public Vacancy VacancyId { get; set; }
        public string Status { get; set; }
    }
}

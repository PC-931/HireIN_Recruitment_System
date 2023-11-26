using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechM.RecruitmentSystem.DataService.Repo;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.DataService.Services
{
    public interface IUserDataService 
    {
        User Login(User u);
        bool Register(User newUser);
    }
}

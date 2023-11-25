using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.DataService.Repo
{
    public interface IUserRepo
    {
        void Read(string email, string pass);
        void Create(User newUser);
        void Update(User updUser);
        void Delete(User usr);
    }
}

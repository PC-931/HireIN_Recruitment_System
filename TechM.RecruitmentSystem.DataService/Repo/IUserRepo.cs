using System.Collections.Generic;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.DataService.Repo
{
    public interface IUserRepo
    {
        List<User> ReadAll();
        User Read(string email, string pass);
        bool Create(User newUser);
        bool Update(User updUser);
        bool Delete(User usr);
    }
}

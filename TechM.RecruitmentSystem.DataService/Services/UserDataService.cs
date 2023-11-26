using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.DataService.Services
{
    public class UserDataService : IUserDataService
    {
        private UserServices userServices;

        public UserDataService()
        {
            userServices = new UserServices();
        }

        public User Login(User u)
        {
            User user = userServices.Read(u.Email, u.Password);
            return user;
        }

        public bool Register(User newUser)
        {
            if ( userServices.Create(newUser) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

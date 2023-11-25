using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.DataService.Services
{
    public class UserDataService : IUserDataService
    {
        private AppDbContext _appDbContext;
        private UserManager<User> userManager;
        private UserStore<User> userStore;

        public UserDataService()
        {
            _appDbContext = new AppDbContext();
            userStore = new UserStore<User>(_appDbContext);
            userManager = new UserManager<User>(userStore);
        }

        public User Login(string email, string pass)
        {
            User user = userManager.Find(email, pass);
            return user;
        }

        public bool Register(User newUser)
        {
            IdentityResult result = userManager.Create(newUser, newUser.Password);
            if (result.Succeeded)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TechM.RecruitmentSystem.Entity;

namespace TechM.RecruitmentSystem.Web.Controllers
{
    public class UserController : Controller
    {

        HttpClient client;

        public UserController()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50291/");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            //var res = client.PostAsync<User>(user).Result;
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User newUser)
        {
            try
            {
                var res = client.PostAsJsonAsync<User>("Register", newUser).Result;
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["err"] = "some error occured";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["err"] = ex.Message;
            }
            return View();
        }
    }
}
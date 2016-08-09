using FreeTime.Common.Models;
using FreeTime.WebApp.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Microsoft.AspNet.Identity.Owin;

namespace FreeTime.WebApp.Controllers
{
    public class UserController : Controller
    {
        private ApplicationUserManager _userManager;

        public UserController()
        {
        }

        public UserController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        [HttpGet]
        public async Task<ActionResult> Index(string username = "")
        {
            if (username != "")
            {
                username = User.Identity.Name;
            }
            //return View();
            return View(new UserIndexViewModel(await UserManager.FindByNameAsync(username)));
        }
    }
}
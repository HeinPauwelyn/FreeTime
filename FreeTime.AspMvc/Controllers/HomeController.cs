using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FreeTime.Common.Models;
using FreeTime.WebApp.ViewModels;
using FreeTime.Common.Services;

namespace FreeTime.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService _categoryService;

        public HomeController(ICategoryService catService)
        {
            _categoryService = catService;
        }

        public ActionResult Index()
        {
            return View(new HomeViewModel(_categoryService.GetAllCategories()));
        }
    }
}
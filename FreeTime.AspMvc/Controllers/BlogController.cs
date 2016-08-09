using FreeTime.Common.Models;
using FreeTime.Common.Services;
using FreeTime.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeTime.WebApp.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogService = new BlogService();

        [HttpGet]
        public ActionResult Index(int page = 1, string categories = "1;2;3;4", int pageSize = 50)
        {
            IEnumerable<Blog> blogs = _blogService.GetByPage(page, categories, pageSize);
            int totalPages = _blogService.GetPages(categories, pageSize);

            return View(new BlogIndexViewModel(blogs, totalPages, page, pageSize));
        }

        [HttpGet]
        public ActionResult Detail(int id = 1)
        {
            return View(_blogService.GetBlogById(id));
        }
    }
}
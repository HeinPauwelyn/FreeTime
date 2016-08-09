using FreeTime.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeTime.WebApp.ViewModels
{
    public class BlogIndexViewModel : IPages
    {
        public IEnumerable<Blog> Blogs { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }

        public BlogIndexViewModel(IEnumerable<Blog> blogs, int totalPages, int currentPage, int pageSize)
        {
            Blogs = blogs;
            CurrentPage = currentPage;
            TotalPages = totalPages;
            PageSize = pageSize;
        }
    }
}
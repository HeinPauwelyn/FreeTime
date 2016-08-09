using FreeTime.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeTime.WebApp.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }

        public HomeViewModel(List<Category> categories)
        {
            Categories = categories;
        }
    }
}
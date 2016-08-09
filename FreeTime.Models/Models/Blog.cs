using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Models
{
    public class Blog : Topic
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
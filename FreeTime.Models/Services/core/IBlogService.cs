using FreeTime.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeTime.Common.Services
{
    public interface IBlogService
    {
        IEnumerable<Blog> GetByPage(int page, string categories, int pageSize);
        int GetPages(string categories, int pageSize);
        Blog GetBlogById(int id);
    }
}

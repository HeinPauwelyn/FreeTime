using System.Collections.Generic;
using FreeTime.Common.Models;

namespace FreeTime.Common.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
    }
}
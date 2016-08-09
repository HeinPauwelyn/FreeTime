using FreeTime.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FreeTime.Common.Repositories;

namespace FreeTime.Common.Services
{
    public class CategoryService : ICategoryService
    {
        private IGenericRepo<Category> _categoryRepo;

        public CategoryService(IGenericRepo<Category> catRepo)
        {
            _categoryRepo = catRepo;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepo.All().ToList<Category>();
        }
    }
}
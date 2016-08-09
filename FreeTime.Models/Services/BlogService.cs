using FreeTime.Common.Models;
using FreeTime.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Services
{
    public class BlogService : IBlogService
    {
        private BlogRepo _blogRepo;

        public BlogService()
            : this (new BlogRepo())
        {
        }

        public BlogService(BlogRepo blogRepo)
        {
            _blogRepo = blogRepo;
        }
        
        public IEnumerable<Blog> GetByPage(int page, string categories, int pageSize)
        {
            pageSize = CheckPageCount(pageSize);
            List<int> catIdsList = GetCategories(ref categories);

            return _blogRepo.GetByPage(page, catIdsList, pageSize);
        }
        
        public int GetPages(string categories, int pageSize)
        {
            pageSize = CheckPageCount(pageSize);
            List<int> catIdsList = GetCategories(ref categories);

            return _blogRepo.GetPages(catIdsList, pageSize);
        }

        public Blog GetBlogById(int id)
        {
            return _blogRepo.GetByID(id);
        }


        private int CheckPageCount(int pageCount)
        {
            if (pageCount != 10 && pageCount != 50 && pageCount != 100)
                pageCount = 50;

            return pageCount;
        }

        private List<int> GetCategories(ref string categories)
        {
            if (categories.Length == 0)
                categories = "1;2;3;4";

            if (categories.Length >= 2 && categories.Contains("0"))
                categories = "0";

            string[] catIdsSplitted = categories.Split(';');
            List<int> catIdsList = new List<int>();

            foreach (string catId in catIdsSplitted)
            {
                int temp = 0;

                if (Int32.TryParse(catId, out temp))
                {
                    catIdsList.Add(temp);
                }
            }

            return catIdsList;
        }
    }
}
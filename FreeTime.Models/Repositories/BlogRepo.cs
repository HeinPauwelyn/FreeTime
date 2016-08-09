using FreeTime.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace FreeTime.Common.Repositories
{
    public class BlogRepo : GenericRepo<Blog>
    {
        public IEnumerable<Blog> GetByPage(int page, List<int> categories, int pageSize)
        {
            return (from blog in dbSet.Include(item => item.Category).Include(item => item.User)
                    where categories.Contains(blog.CategoryId)
                    orderby blog.CreationDateStamp
                    select blog).Skip((page - 1) * pageSize).Take(pageSize).ToList<Blog>();
        }

        public int GetPages(List<int> categories, int pageSize)
        {
            return (from b in dbSet
                    where categories.Contains(b.CategoryId)
                    select b).Count() / pageSize;
        }

        public override Blog GetByID(object id)
        {
            int iid = Convert.ToInt32(id);

            return (from b in dbSet.Include(item => item.Category).Include(item => item.User)
                    where b.TopicId == iid
                    select b).SingleOrDefault<Blog>();
        }
    }
}
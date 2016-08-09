using FreeTime.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Services
{
    public class VotingService : IVotingService
    {
        private IBlogService _blogService = new BlogService();

        public string CheckVote(string vote, int topicId)
        {
            Blog blog = _blogService.GetBlogById(topicId);

            if (vote != "up" && vote != "down" && blog != null) 
            {
                return "Ongeldige stem poging";
            }
            
            return "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Models
{
    public class Reaction : Topic, IVote
    {
        [Key]
        public int ReactionId { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
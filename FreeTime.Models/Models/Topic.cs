using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Models
{
    public class Topic: IVote
    {
        [Key]
        public int TopicId { get; set; }

        [DataType("nvarchar(128)")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public Topic UpdatedTopicId { get; set; }
        public int? RefUpdatedTopicId { get; set; }
        public bool? FallBack { get; set; }

        [DataType(DataType.Text)]
        public string Text { get; set; }
        public int DownVotes { get; set; }
        public int UpVotes { get; set; }

        [Timestamp]
        public byte[] CreationDateStamp { get; set; }

        //[NotMapped]
        //public DateTime CreationDate
        //{
        //    get
        //    {
        //        return new DateTime(CreationDateStamp[0], CreationDateStamp[1], CreationDateStamp[2]);
        //    }
        //}

        public int CalculateTotal()
        {
            return UpVotes - DownVotes;
        }
    }
}
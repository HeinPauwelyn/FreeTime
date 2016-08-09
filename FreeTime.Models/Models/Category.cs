using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreeTime.Common.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }
        [DataType(DataType.Text)]
        public string Style { get; set; }
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Category)
            {
                Category cat = obj as Category;

                return cat.Name == Name;
            }

            return false;
        }
    }
}
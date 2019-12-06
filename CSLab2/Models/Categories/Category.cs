using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSLab2.Models.Categories
{
    public class Category
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "User name")]
        public string Name { get; set; }

        [Display(Name = "User Information")]
        public string Data { get; set; }

        [Display(Name = "Creation date")]
        public DateTime CreatedAt { get; set; }
    }
}

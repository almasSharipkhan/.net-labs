using CSLab2.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSLab2.Models.Comments
{
    public class Comment
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Author name")]
        public User User { get; set; }

        [Display(Name = "Data")]
        public string Data { get; set; }

        [Display(Name = "Release date")]
        public DateTime CreatedAt { get; set; }
    }
}

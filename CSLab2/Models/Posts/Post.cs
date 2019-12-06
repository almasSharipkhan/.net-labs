using CSLab2.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSLab2.Models.Posts
{
    public class Post
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Post name")]
        public string Name { get; set; }

        [Display(Name = "Post user")]
        public User User { get; set; }

        [Display(Name = "Comment data")]
        public string Data { get; set; }

        [Display(Name = "Creation date")]
        public DateTime CreatedAt { get; set; }
    }
}

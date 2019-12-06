using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSLab2.Models.Groups
{
    public class Group
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Group name")]
        public string Name { get; set; }

        [Display(Name = "Group Information")]
        public string Data { get; set; }

        [Display(Name = "Release date")]
        public DateTime CreatedAt { get; set; }
    }
}

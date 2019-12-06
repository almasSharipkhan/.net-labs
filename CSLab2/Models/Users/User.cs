using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSLab2.Models.Users
{
    public class User
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "User name")]
        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [Display(Name = "User surname")]
        [Required]
        [StringLength(40)]
        public string Surname { get; set; }

        [Display(Name = "User Information")]
        public string Data { get; set; }

        [Display(Name = "Creation date")]
        public DateTime CreatedAt { get; set; }
    }
}

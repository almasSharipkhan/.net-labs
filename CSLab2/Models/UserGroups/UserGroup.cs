using CSLab2.Models.Groups;
using CSLab2.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSLab2.Models.UserGroups
{
    public class UserGroup
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "User")]
        public User Name { get; set; }

        [Display(Name = "Group")]
        public Group Data { get; set; }
    }
}

using CSLab2.Models.Comments;
using CSLab2.Models.Groups;
using CSLab2.Models.Posts;
using CSLab2.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSLab2.Models.Categories;
using CSLab2.Models.UserGroups;

namespace CSLab2.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Group> UserGroups { get; set; }

        public DbSet<Group> Categories { get; set; }

        public DbSet<CSLab2.Models.Categories.Category> Category { get; set; }

        public DbSet<CSLab2.Models.UserGroups.UserGroup> UserGroup { get; set; }
    }
}

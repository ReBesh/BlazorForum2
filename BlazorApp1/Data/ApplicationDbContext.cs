using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<ForumPost> ForumPosts { get; set; }

        public DbSet<ForumTopic> ForumTopics { get; set; }

        public DbSet<ForumCategory> ForumCategories { get; set; }
    }
}

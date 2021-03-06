﻿using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ForumPost> ForumPosts { get; set; }

        public DbSet<ForumTopic> ForumTopics { get; set; }

        public DbSet<ForumCategory> ForumCategories { get; set; }

        public DbSet<Forum> Forums { get; set; }

        public DbSet<Theme> Themes { get; set; }

        public DbSet<Configuration> Configuration { get; set; }

        public DbSet<SitePage> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

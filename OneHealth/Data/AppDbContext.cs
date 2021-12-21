﻿using Microsoft.EntityFrameworkCore;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
          
        }
        public DbSet<AboutSection> AboutSections { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<CategoryToNews> CategoryToNews { get; set; }
        public DbSet<Commenter> Commenters { get; set; }
        public DbSet<CustoMUser> CustoMUsers { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsCategory> NewsCategories { get; set; }
        public DbSet<NewsComment> NewsComments { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToNews> TagToNews { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Orders.Share.Entities;

namespace Orders.Backend.Data
{
    public class DataContext : DbContext
    {
        //CONSTRUCTOR DE LA BASE DE DAOS
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //  
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SeasonTracker.Models
{
    // To Enable Migrations, once this file is completed:
    //  1) PM > EntityFrameworkCore\add-migration InitialCreate
    //  2) PM > EntityFrameworkCore\update-database
    public class ApplicationDbContext : DbContext
    {
        const string connectionString = @"Server=(localdb)\mssqllocaldb;Database=SeasonTrackerWPF;Trusted_Connection=True;";

        public DbSet<Watchlist> Watchlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

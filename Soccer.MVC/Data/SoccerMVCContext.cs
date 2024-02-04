using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Soccer.MVC.Models;

namespace Soccer.MVC.Data
{
    public class SoccerMVCContext : DbContext
    {
        public SoccerMVCContext(DbContextOptions<SoccerMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Soccer.MVC.Models.Award> Award { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.Player> Player { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.Award_Season> Award_Season { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.Category> Category { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.Country> Country { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.News> News { get; set; }
        public DbSet<Soccer.MVC.Models.Player_Team> Player_Team { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.Post_Type> Post_Type { get; set; } = default!;
        public DbSet<Soccer.MVC.Models.Team> Team { get; set; } = default!;
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Configure the database connection here (connection string, etc.)
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Soccer.MVC.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}
    }
}

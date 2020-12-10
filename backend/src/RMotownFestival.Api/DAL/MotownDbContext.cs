using Microsoft.EntityFrameworkCore;
using RMotownFestival.Api.Data;
using RMotownFestival.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RMotownFestival.Api.DAL
{
    public class MotownDbContext: DbContext
    {
        public MotownDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }

        //public DbSet<Festival> Festivals { get; set; }

        //public DbSet<Schedule> Schedules { get; set; }

        //public DbSet<ScheduleItem> ScheduleItems { get; set; }

        public DbSet<Stage> Stages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            FestivalDataSource.Current.Artists.ToList().ForEach(artist => modelBuilder.Entity<Artist>().HasData(artist));
            FestivalDataSource.Current.Stages.ToList().ForEach(stage => modelBuilder.Entity<Stage>().HasData(stage));
        }
    }
}

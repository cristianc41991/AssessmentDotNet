using AssessmentDotNet2020.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentDotNet2020.Server
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>().HasKey(x => x.Id);
            modelBuilder.Entity<Cola>().HasKey(x => x.Id);
            modelBuilder.Entity<ColaPeople>().HasKey(x => new { x.ColaId, x.PeopleId });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Cola> Colas { get; set; }
        public DbSet<ColaPeople> ColaPeoples { get; set; }
    }
}

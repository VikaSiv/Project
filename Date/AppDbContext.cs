using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Date
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<AreaCoordinate> AreaCoordinates { get; set; }
        public DbSet<AreaProfile> AreaProfiles {  get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Picket> Pickets { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileCoordinate> ProfileCoordinates { get; set; }
        public DbSet<ProfilePicket> ProfilePickets { get; set; }
        public DbSet<Models.Project> Projects { get; set; }
        public DbSet<ProjectArea> ProjectAreas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-R20BC7O9;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }
    }
}

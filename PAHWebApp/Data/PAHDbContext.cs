using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAHWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PAHWebApp.Data
{
    public class PAHDbContext : DbContext
    {
        public PAHDbContext(DbContextOptions<PAHDbContext> options) : base(options) { }
        public virtual DbSet<PharmSchedule> PharmSchedule { get; set; }
        public virtual DbSet<PharmBatch> PharmBatch { get; set; }
        public virtual DbSet<PharmResponse> PharmResponse { get; set; }
        public virtual DbSet<PharmScrubLog> PharmScrubLog { get; set; }
        public virtual DbSet<PharmHeader> PharmHeader { get; set; }
        public virtual DbSet<PharmDE> PharmDE { get; set; }
        public virtual DbSet<PharmCD1> PharmCD1 { get; set; }
        public virtual DbSet<PharmCD2> PharmCD2 { get; set; }
        public virtual DbSet<BatchStatus> BatchStatus { get; set; }
        public virtual DbSet<ScheduleStatus> ScheduleStatus { get; set; }
        public virtual DbSet<SystemConfiguration> SystemConfiguration { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Encounter");
            base.OnModelCreating(builder);
        }
    }
}

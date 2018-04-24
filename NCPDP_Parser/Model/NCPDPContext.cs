using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace NCPDP_Parser.Model
{

    public partial class NCPDPContext : DbContext
    {
        public NCPDPContext(DbContextOptions<NCPDPContext> options)
            : base(options)
        {
        }

        public DbSet<HisCompound1> HisCompound1 { get; set; }
        public DbSet<HisCompound2> HisCompound2 { get; set; }
        public DbSet<HisDetail> HisDetails { get; set; }
        public DbSet<HisHeader> HisHeaders { get; set; }
        public DbSet<UtlCompound> UtlCompounds { get; set; }
        public DbSet<UtlDetail> UtlDetails { get; set; }
        public DbSet<UtlHeader> UtlHeaders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CoreEDMCustomDBEntities"].ToString());
            }
        }
    }
}


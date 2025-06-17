using Microsoft.EntityFrameworkCore;
using SIMS_dotNet.Models;

namespace SIMS_dotNet.Data
{
    public class SIMSContext : DbContext
    {
        public SIMSContext(DbContextOptions<SIMSContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Warehouses> Warehouses { get; set; }
        public DbSet<Racks> Racks { get; set; }
        public DbSet<Slots> Slots { get; set; }
        public DbSet<Records> Records { get; set; }
        //TODO: clase agregada o modelo, añadirlo con esta nomenclatura public DbSet<Storage> Storage { get; set; }
    }
}

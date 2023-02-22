using Microsoft.EntityFrameworkCore;
using RUAP_projekt.Models.Entities;

namespace RUAP_projekt.Data
{
    public class FlagsDbContext : DbContext
    {
        public FlagsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Flag> Flags { get; set; }
    }
}

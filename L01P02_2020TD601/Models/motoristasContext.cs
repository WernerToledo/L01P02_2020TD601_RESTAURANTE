using L01_2020TD601.Models;
using Microsoft.EntityFrameworkCore;

namespace L01P02_2020TD601.Models
{
    public class motoristasContext : DbContext
    {
        public motoristasContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<motoristas> motoristas { get; set; }
    }
}

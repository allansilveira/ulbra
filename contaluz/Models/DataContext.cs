using Microsoft.EntityFrameworkCore;

namespace contaluz.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Light> Conta { get; set; }
    }
}
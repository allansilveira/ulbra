using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;

namespace ToDoList.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        public DbSet<Light> Conta { get; set; }
        public DbSet<House> Imovel { get; set; }
        
    }
}
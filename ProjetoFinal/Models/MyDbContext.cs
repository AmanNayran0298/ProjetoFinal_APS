using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace ProjetoFinal.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Usuario> Users { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
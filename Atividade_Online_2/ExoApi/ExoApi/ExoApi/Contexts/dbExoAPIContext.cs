using Microsoft.EntityFrameworkCore;
using ExoApi.Models;

namespace ExoApi.Contexts
{
    public class dbExoAPIContext : DbContext
    {
        public dbExoAPIContext()
        {
        }
        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-BMONJN65\\SQLEXPRESS; initial catalog = dbExoAPI; ; Integrated Security = true");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
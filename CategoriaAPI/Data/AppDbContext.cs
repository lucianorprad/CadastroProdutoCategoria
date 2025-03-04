using CategoriaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoriaAPI.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


    }
}

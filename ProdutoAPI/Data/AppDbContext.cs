using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Models;

namespace ProdutoAPI.Data
{
    public class AppDbContext :  DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração da relação sem propriedade de navegação
            modelBuilder.Entity<Produto>()
                .HasOne<CategoriaAPI.Models.Categoria>()
                .WithMany() 
                .HasForeignKey(p => p.CategoriaId)
                .IsRequired(true);

            base.OnModelCreating(modelBuilder);
        }

    }
}

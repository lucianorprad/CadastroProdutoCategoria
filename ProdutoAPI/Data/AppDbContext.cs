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
                .HasOne<CategoriaAPI.Models.Categoria>() // Especifica o tipo da entidade relacionada
                .WithMany() // Indica que não há propriedade de navegação inversa
                .HasForeignKey(p => p.CategoriaId)
                .IsRequired(false); // Caso CategoriaId possa ser nulo

            base.OnModelCreating(modelBuilder);
        }

    }
}

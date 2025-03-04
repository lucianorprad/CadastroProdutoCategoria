using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutoAPI.Models
{
    public class Produto
    {

        [Key]
        public int ProdutoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(250)]
        public string Descricao { get; set; }

        [ForeignKey ("CategoriaId")]
        public int CategoriaId { get; set; }

    }
}

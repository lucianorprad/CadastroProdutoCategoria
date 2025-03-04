using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations;
using CategoriaAPI.Models;


namespace CategoriaAPI.Models
{
    public class Categoria
    {

        [Key]
        public int CategoriaId { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }


    }
}

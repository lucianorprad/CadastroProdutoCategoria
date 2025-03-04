using Microsoft.AspNetCore.Mvc;
using ProdutoAPI.Models;
using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Data;
using Swashbuckle.AspNetCore.Annotations;

namespace ProdutoAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;



        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]

        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();


            return CreatedAtAction (nameof(GetProdutos), new { id = produto.ProdutoId},produto);
        }



    }
}

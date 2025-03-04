using Microsoft.AspNetCore.Mvc;
using CategoriaAPI.Models;
using Microsoft.EntityFrameworkCore;
using CategoriaAPI.Data;
using Swashbuckle.AspNetCore.Annotations;

namespace CategoriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext _context;


        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {

            try
            {
                return await _context.Categoria.ToListAsync();

            }


            catch (Exception ex)
            {
                return StatusCode(500, "Erro Inesperado" + ex.Message);
            }
        }

        [HttpPost]

        public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategorias), new { id = categoria.CategoriaId }, categoria);

        }


        [HttpDelete]

        public async Task<ActionResult<Categoria>>  DeleteCategoria(Categoria categoria)
        {
            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();

            return Ok(categoria);
        }

        [HttpPut]

        public async Task<ActionResult<Categoria>> PutCategoria(Categoria categoria)
        {
            _context.Categoria.Update(categoria);
            await _context.SaveChangesAsync();

            return Ok(categoria);
        }



    }
}

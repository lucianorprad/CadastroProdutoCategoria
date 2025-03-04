using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult CadastrarProduto()
        {
            return View();
        }
    }
}

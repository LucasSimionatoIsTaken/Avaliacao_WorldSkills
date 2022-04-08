using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Context
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly WSTowersContext _ctx = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ctx.Produtos.ToList());
        }
    }
}

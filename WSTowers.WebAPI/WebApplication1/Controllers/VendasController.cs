using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Domains;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly WSTowersContext _ctx = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ctx.Vendas.OrderBy(x => x.Quantidade * x.Produto.Valor).ToList());
        }
    }
}

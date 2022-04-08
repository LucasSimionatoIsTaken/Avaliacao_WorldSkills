using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ParticipantesController : ControllerBase
    {
        private readonly WSTowersContext _ctx = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ctx.Participantes.ToList());
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication1.Context;
using WebApplication1.Domains;

namespace WebApplication1.Controllers
{
    public class Entrada
    { 
        public string? user { get; }
        public string? password { get; }
    }

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly WSTowersContext _ctx = new();

        [HttpPost]
        public IActionResult Post(Entrada entrada)
        {
            Participante participante = _ctx.Participantes.FirstOrDefault(x => x.Nome.Substring(0, 1) == entrada.user.Substring(0, 1) &&
                                                     x.Nome.Trim().Contains(entrada.user.Substring(1, entrada.user.Length - 1)) &&
                                                     x.Cidade.Estado.Regiao.Regiao1 == entrada.password.Substring(0, 2) &&
                                                     x.Genero.Genero1 == entrada.password.Substring(2, 1) &&
                                                     x.Idade.ToString() == entrada.password.Substring(3, 2));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("F@CPgNl1HZ8nxb*&GgN5D&Gq*BiR@00757s9ylbtMo#!op%ZJe"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Jti, participante.Id.ToString())
            };

            var token = new JwtSecurityToken
                (
                    issuer: "WSTowers",
                    audience: "WSTowers",
                    claims,
                    signingCredentials: credentials
                );

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}

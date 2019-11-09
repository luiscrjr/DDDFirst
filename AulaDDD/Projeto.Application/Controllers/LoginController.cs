using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Projeto.Application.Models;

namespace Projeto.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] LoginModel model,
            [FromServices] TokenConfiguration tokenConfiguration,
            [FromServices] SigningConfiguration signingConfiguration
            )
        {
            if (ModelState.IsValid)
            {
                try
                {

                    if ("lribeiro".Equals(model.Login) && "adm$$lr".Equals(model.Senha))
                    {

                        ClaimsIdentity identity = new ClaimsIdentity(
                        new GenericIdentity(model.Login, "Login"),
                        new[] {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                            new Claim(JwtRegisteredClaimNames.UniqueName, model.Login)
                        });

                        DateTime dataCriacao = DateTime.Now;
                        DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfiguration.Seconds);

                        var handler = new JwtSecurityTokenHandler();
                        var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                        {
                            Issuer = tokenConfiguration.Issuer,
                            Audience = tokenConfiguration.Audience,
                            SigningCredentials = signingConfiguration.SigningCredentials,
                            Subject = identity,
                            NotBefore = dataCriacao,
                            Expires = dataExpiracao
                        });
                        var token = handler.WriteToken(securityToken);

                        return Ok(new
                        {
                            authenticated = true,
                            created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                            expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                            accessToken = token,
                            message = "OK"
                        });


                    }
                    else
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, "Credenciais inválidas.");
                    }
                }
                catch (Exception e)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }
        }
    }
}
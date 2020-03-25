using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Dominios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Servicos.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        //Declara uma váriavel do tipo IUsuarioRepositorio
        private ILogin _loginRepositorio;

        //Utiliza injeção de dependência definida no startup
        public LoginController(ILogin loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }


        /// <summary>
        /// Efetua login do usuario
        /// </summary>
        /// <param name="login">Recebe um usuario com email e senha</param>
        /// <returns>Retorna Ok com o token caso haja sucesso ou bad request</returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                var Usuario = _loginRepositorio.BuscarUser(login.Email, login.Senha);

                if (Usuario == null)
                    return NotFound(new { mensagem = "Email ou senha inválidos." });

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, Usuario.Email),
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("iexpo-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "iExpo.WebApi",
                    audience: "iExpo.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: creds);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new { sucesso = false, mensagem = ex.Message });
            }
        }

    }
}
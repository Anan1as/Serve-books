using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Serve_books.Data;
using Serve_books.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Serve_books.Controllers
{
    [ApiController]
    [Route("/[controller]")]

    public class LoginController : ControllerBase
    {
        private readonly DataContext _context;
        public LoginController (DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task <IActionResult> login ([FromBody] UserDto User) 
        { 
            //Hacemos la validación con la base de datos
            var usuarios = await _context.Usuarios.FirstOrDefaultAsync(u => u.Correo == User.Correo && u.Contraseña == User.Contraseña);
            if (usuarios == null)
            {
                return Unauthorized("Hubo un problema en la contraseña o en el correo");
            }
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("mcjfnvjfnvhbvncfjccmkcc-nduxhdbhcbfhcbfhvcrvyecbcdnndjenjden@"));
            var singningCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            //Agregamos las opciones del token 
            var tokenOptions = new JwtSecurityToken(
                issuer: "http://localhost:5113",
                audience: "http://localhost:5113",
                claims: new List<Claim>(),
                expires: DateTime.Now.AddHours(1),
                signingCredentials: singningCredentials
            );
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return Ok (new {Token = token});
        }
    }
}
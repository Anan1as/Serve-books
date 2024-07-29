using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serve_books.Data;
using Serve_books.Dto;
using Serve_books.Models;

namespace Authcontroller
{
    public class Authcontroller : Controller
    {
        private readonly DataContext _context;
        public Authcontroller (DataContext context)
        {
            {
                _context = context;
            }
        }
        [HttpPost]
        public async Task <IActionResult> Auth ([FromBody] UserDto user)
        {
            var User = await _context.Usuarios.FirstOrDefaultAsync(u => u.Correo == user.Correo  && u.Contraseña == user.Contraseña); //In this line i need the Hash password
            if (user == null )
            {
                return Unauthorized("Please fill  all fields");
            }
            var SecretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(@Environment.GetEnvironmentVariable("JwtToken"))); //variable key
            var SigninCredentials = new SigningCredentials(SecretKey, SecurityAlgorithms.HmacSha256);
            var TokenOptions = new JwtSecurityToken(
                issuer : "http:", 
                audience :"http:",
                claims : new List<Claim>(),
                expires : DateTime.Now.AddMinutes(30),
                signingCredentials : SigninCredentials
            );
            //Token Generated
            var TokenString = new JwtSecurityTokenHandler().WriteToken(TokenOptions);
            return Ok (new{Token = TokenString});

            }
    }
}
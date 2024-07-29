using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serve_books.Services.Prestamo;
using Serve_books.Models;


namespace Serve_books.Controllers.Prestamo
{
    public class PrestamoController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        public PrestamoController(IClienteRepository clienteRepository)
        {
            _clienteRepository =  clienteRepository; 
        }
        
        [HttpPost]
        [Route("Prestamo/Creado")]
        public IActionResult CrearPrestamo(Prestamo prestamo)
        {
            try
            {
                _clienteRepository.CrearPrestamo(prestamo);
                return Ok(prestamo);
            }
            catch (System.Exception)
            {
                return BadRequest("No se puede crear el prestamo");
            }
        }
    }
}
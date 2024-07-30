using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Servebooks.Services;
using Serve_books.Models;


namespace Servebooks.Controllers
{
    public class PrestamoController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public PrestamoController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
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
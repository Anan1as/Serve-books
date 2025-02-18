using Serve_books.Models;
using Servebooks.Services;
using Microsoft.AspNetCore.Mvc;

namespace Servebooks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibroUpdateController : ControllerBase
    {
        private readonly ILibrosRepository _librosRepository;

        public LibroUpdateController(ILibrosRepository librosRepository)
        {
            _librosRepository = librosRepository;
        }

        [HttpPut]
        public IActionResult ActualizarLibro(Libro libro)
        {
            try
            {
                _librosRepository.ActualizarLibro(libro);
                return Ok(libro);
            }
            catch (System.Exception)
            {
                return BadRequest("No se pudo actualizar el libro");
            }
        }
    }
}
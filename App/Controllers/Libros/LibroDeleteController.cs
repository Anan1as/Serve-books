using Serve_books.Models;
using Servebooks.Services;
using Microsoft.AspNetCore.Mvc;

namespace Servebooks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibroDeleteController : ControllerBase
    {
        private readonly ILibrosRepository _librosRepository;

        public LibroDeleteController(ILibrosRepository librosRepository)
        {
            _librosRepository = librosRepository;
        }

        [HttpDelete]
        public IActionResult EliminarLibro(Libro libro)
        {
            try
            {
                _librosRepository.EliminarLibro(libro);
                return Ok(libro);
            }
            catch (System.Exception)
            {
                return BadRequest("No se pudo eliminar el libro");
            }
        }
    }
}
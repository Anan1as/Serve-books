using Serve_books.Models;
using Servebooks.Services;
using Microsoft.AspNetCore.Mvc;

namespace Servebooks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibroController : ControllerBase
    {
        private readonly ILibrosRepository _librosRepository;

        public LibroController(ILibrosRepository librosRepository)
        {
            _librosRepository = librosRepository;
        }

        [HttpGet]
        public IActionResult ObtenerLibros()
        {
            return Ok(_librosRepository.ObtenerLibros());
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerLibro(int id)
        {
            return Ok(_librosRepository.ObtenerLibro(id));
        }
    }
}
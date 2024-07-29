using Servebooks.Models;
using Servebooks.Services;
using Servebooks.Data;
using Microsoft.EntityFrameworkCore;

namespace Servebooks.Services
{
    public class LibrosRepository : ILibrosRepository
    {
        private readonly DataContext _context;

        public LibrosRepository(DataContext context)
        {
            _context = context;
        }

        public void AñadirLibro(Libro libro)
        {
            _context.Libro.Add(libro);
            _context.SaveChanges();
        }
    }
}
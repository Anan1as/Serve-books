using Serve_books.Models;
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

        public IEnumerable<Libro> ObtenerLibros()
        {
            return _context.Libro;
        }

        public Libro ObtenerLibro(int id)
        {
            return _context.Libro.Find(id);
        }

        public void ActualizarLibro(Libro libro)
        {
            _context.Libro.Update(libro);
            _context.SaveChanges();
        }

        public void EliminarLibro(int id)
        {
            var libro = _context.Libro.Find(id);
            _context.Libro.Remove(libro);
            _context.SaveChanges();
        }

        public void AñadirLibro(Libro libro)
        {
            _context.Libro.Add(libro);
            _context.SaveChanges();
        }
    }
}
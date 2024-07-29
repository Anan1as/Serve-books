using Serve_books.Models;

namespace Servebooks.Services
{
    public interface ILibrosRepository
    {
        IEnumerable<Libro> ObtenerLibros();
        Libro ObtenerLibro(int id);
        void AñadirLibro(Libro libro);
        void ActualizarLibro(Libro libro);
        void EliminarLibro(Libro libro);
    }
}
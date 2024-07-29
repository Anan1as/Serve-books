using Servebooks.Models;

namespace Servebooks.Services
{
    public interface ILibrosRepository
    {
        void AñadirLibro(Libro libro);
    }
}
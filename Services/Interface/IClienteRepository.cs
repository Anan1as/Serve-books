using Serve_books.Models;

namespace Servebooks.Services
{
    public interface IClienteRepository
    {
        void CrearPrestamo(Prestamo prestamo);
    }
}
using Serve_books.Models;
using Servebooks.Services;
using Servebooks.Data;
using Microsoft.EntityFrameworkCore;


namespace Servebooks.Services
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public void CrearPrestamo(Prestamo prestamo)
        {
            _context.Prestamo.Add(prestamo);
            _context.SaveChanges();
        }
  
    }
}



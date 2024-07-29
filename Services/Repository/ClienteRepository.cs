using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serve_books.Models;
using Serve_books.Data;

namespace Serve_books.Services.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext DbContext;

        public ClienteRepository(DataContext dbContext)
        {
            DbContext = dbContext;
        }

        public void CrearPrestamo(Prestamo prestamo)
        {
            _context.Prestamo.Add(prestamo);
            _context.SaveChanges();
        }
  
    }
}



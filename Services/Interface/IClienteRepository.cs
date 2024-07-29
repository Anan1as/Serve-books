using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serve_books.Models;

namespace Serve_books.Services.Interface
{
    public interface IClienteRepository
    {
        void CrearPrestamo(Prestamo prestamo);
    }
}
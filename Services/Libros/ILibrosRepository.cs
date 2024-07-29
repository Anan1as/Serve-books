using System;
using System.Collections.Generic;
using System.Linq;
using Servebooks.Models;

namespace Serve_books.Services.Libros
{
    public interface ILibrosRepository
    {
        void AñadirLibro(Libro libro);
    }
}
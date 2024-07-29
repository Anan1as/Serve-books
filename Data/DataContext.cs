using Serve_books.Models;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Serve_books.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {

        }
        //Aqui van los modelos
        public DbSet <Autor> Autores {get; set; }
        public DbSet <Documento>  Documentos {get; set;}
        public DbSet <Genero> Generos {get; set; }
        public DbSet <Historial> Historiales {get; set;}
        public DbSet <libro> Libros {get; set;}
        public DbSet <Prestamo> prestamos {get; set; }
        public DbSet <Usuario> Usuarios {get; set; }
    }
}
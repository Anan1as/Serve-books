using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Serve_books.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
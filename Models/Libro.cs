using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servebooks.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int AutorId { get; set; }
        public DateTime FechaDePublicacion { get; set; }
        public int NumeroDeCopias { get; set; }
        public int GeneroId { get; set; }
        public string Estado { get; set; }
    }

}
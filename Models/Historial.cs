using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Servebooks.Models
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int LibroId { get; set; }
    public DateTime FechaDePrestamo { get; set; }
    public DateTime FechaEntrega { get; set; }

}
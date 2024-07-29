//using Servebooks.Models;
using Microsoft.EntityFrameworkCore;
using Serve_books.Models;

namespace Servebooks.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {

        }
        //Aqui van los modelos
    }
}
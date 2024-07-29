//using Servebooks.Models;
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
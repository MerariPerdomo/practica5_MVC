using Microsoft.EntityFrameworkCore;
namespace practicaMVC.Models

{
    public class equiposDbcontext : DbContext
    {
        public equiposDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<marcas> marcas { get; set; }
    }
}

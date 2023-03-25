using Microsoft.EntityFrameworkCore;
using practicaMVC.Models;
namespace practicaMVC.Models

{
    public class equiposDbcontext : DbContext
    {
        public equiposDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<practicaMVC.Models.estados_equipo>? estados_equipo { get; set; }
        public DbSet<practicaMVC.Models.estados_reserva>? estados_reserva { get; set; }
        public DbSet<practicaMVC.Models.facultades>? facultades { get; set; }
        public DbSet<practicaMVC.Models.tipo_equipo>? tipo_equipo { get; set; }
        public DbSet<practicaMVC.Models.usuarios>? usuarios { get; set; }
        public DbSet<practicaMVC.Models.carreras>? carreras { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using MagicVilla_API.Modelos;
namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) //constructor donde se indica que nuestra base "dbcontext" se le va mandar toda la configuracion que tenemos en el servicio atravez de inyeccion de dependencia 
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(  new Villa()
            {
                Id = 1,
                Nombre = "Villa Real",
                Detalle = "Detalles de la villa",
                ImagenUrl = "",
                Ocupantes = 5,
                MetrosCuadrados = 50,
                Tarifa = 200,
                Amenidad="",
                FechaCreacion= DateTime.Now,    
                FechaActualizacion= DateTime.Now   
            },
            new Villa()
            {
                Id = 2,
                Nombre = "Villa No Real",
                Detalle = "Detalles de la villa...",
                ImagenUrl = "",
                Ocupantes = 10,
                MetrosCuadrados = 150,
                Tarifa = 500,
                Amenidad = "",
                FechaCreacion = DateTime.Now,
                FechaActualizacion = DateTime.Now
            });
        }

    }
}

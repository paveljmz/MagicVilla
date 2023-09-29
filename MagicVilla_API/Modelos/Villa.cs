using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //sirve para poder incrementar de 1 en 1 el id  automaticamente 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        [Required]
        public double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }

    }
}

﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required]
        public int Ocupantes { get; set; }
        [Required]
        public double Tarifa { get; set; }
        [Required]
        public string ImagenUrl { get; set; }
      
        public string Amenidad { get; set; }

        [Required]
        public int  MetrosCuadrados { get; set; }
      

    }
}

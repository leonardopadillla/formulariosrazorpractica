using System;
using System.ComponentModel.DataAnnotations;

namespace formulariosrazorpractica.Models
{
    public class marcas{
    
        [Key]
        public int id_marcas {get; set;}
        public string nombre_marca {get; set;}
        public string estados {get; set;}
    }
}
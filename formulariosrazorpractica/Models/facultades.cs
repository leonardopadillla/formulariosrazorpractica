using System;
using System.ComponentModel.DataAnnotations;

namespace formulariosrazorpractica.Models
{
    public class facultades{
    
        [Key]
        public int facultad_id {get; set;}
        public string nombre_facultad {get; set;}        
    }
}
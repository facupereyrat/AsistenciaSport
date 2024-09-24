using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSport.BD.Data.Entity
{
    public class Asistencias
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El ingreso del codigo es de caracter OBLIGATORIO")]
        [MaxLength(40, ErrorMessage = "El codigo ingresado es INCORRECTO")]
        public DateTime Ingreso { get; set; }
        public DateTime Egreso { get; set; }  
        public int IdMiembro { get; set; }
        public required Miembro Miembro { get; set; }
    }
}

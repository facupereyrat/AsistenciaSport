using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSport.BD.Data.Entity
{
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El nombre del miembro es de caracter OBLIGATORIO")]
        [MaxLength(40, ErrorMessage = "El nombre ingresado es INCORRECTO")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El apellido del miembro es de caracter OBLIGATORIO")]
        [MaxLength(40, ErrorMessage = "El apellido ingresado es INCORRECTO")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "El ingreso del codigo es de caracter OBLIGATORIO")]
        [MaxLength(40, ErrorMessage = "El codigo ingresado es INCORRECTO")]
        public int Fecha { get; set; }
        [MaxLength(40, ErrorMessage = "El fecha ingresada es INCORRECTA")]
        public string Estado { get; set; }
        //En caso de deber cuotas u haber sido  dado de baja por los administradores mostrar
        [MaxLength(40, ErrorMessage = "El estado de su membresia esta actualmente en revision, porfavor comuniquese con el administrador")]
        public int IdAdministrador { get; set; }
        public Administrador Administrador { get; set; }
    }
}

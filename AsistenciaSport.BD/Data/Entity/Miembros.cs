using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSport.BD.Data.Entity
{
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Codigo { get; set; }
        public int Fecha { get; set; }
        public string Estado { get; set; }
        public int IdAdministrador { get; set; }
    }
}

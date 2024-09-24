using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSport.BD.Data.Entity
{
    public class Cuotas
    {
        public int Id { get; set; }
        public int Monto { get; set; }
        public int Fecha { get; set; }
        public String Estado { get; set; }
        public int IdMiembro { get; set; }
        public int IdAdministrador { get; set; }
    }
}

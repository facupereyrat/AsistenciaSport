using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSport.BD.Data.Entity
{
    public class Asistencias
    {
        public int Id { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Egreso { get; set; }  
        public int IdMiembro { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaSport.BD.Data.Entity
{

    public class Administrador
    {public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string FechaRegistro { get; set; }

    }
}

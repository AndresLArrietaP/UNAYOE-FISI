﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNAYOE.FISI.Entidades.Core
{
    public class Usuario
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Codigo { get; set; }
        public TipoUsuario oTipoPersona { get; set; }
        public bool Estado { get; set; }
    }
}

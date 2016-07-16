using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiblioTech.Entity;

namespace BiblioTech.Modelos
{
    public class LibroDevolucion
    {
        public bool Seleccionado { set; get; }
        public libros Libro { set; get; }
    }
}

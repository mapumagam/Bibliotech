using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiblioTech.Entity;

namespace BiblioTech.Modelos
{
    public class UsuarioBusqueda
    {
        public usuarios Lector { set; get; }
        public string Matricula
        {
            get { 
                return this.Lector.matricula; 
            }
        }
        public string NombreLector {
            get
            {
                StringBuilder sbNombre = new StringBuilder();

                sbNombre.Append(this.Lector.primer_nombre);
                sbNombre.Append(" ");
                sbNombre.Append(this.Lector.segundo_nombre);
                sbNombre.Append(" ");
                sbNombre.Append(this.Lector.apellido_paterno);
                sbNombre.Append(" ");
                sbNombre.Append(this.Lector.apellido_materno);

                return (sbNombre.ToString());
            }
        }
    }
}

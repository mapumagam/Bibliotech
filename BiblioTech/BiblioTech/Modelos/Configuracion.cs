using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using BiblioTech.Entity;

namespace BiblioTech.Modelos
{
    public static class Configuracion
    {
        public static string ConnectionString
        {
            get
            {
                var Configuraciones = Properties.Settings.Default;
                string ConnectionString = ConfigurationManager.ConnectionStrings["BibliotecaEntities"].ConnectionString;

                ConnectionString = ConnectionString.Replace("{server}", Configuraciones.ServidorBD);
                ConnectionString = ConnectionString.Replace("{user}", Configuraciones.UsuarioBD);
                ConnectionString = ConnectionString.Replace("{pass}", Configuraciones.ContraseñaDB);
                ConnectionString = ConnectionString.Replace("99999", Configuraciones.PuertoBD);
                ConnectionString = ConnectionString.Replace("{db}", Configuraciones.BaseDeDatos);

                return (ConnectionString);
            }
        }
    }
}

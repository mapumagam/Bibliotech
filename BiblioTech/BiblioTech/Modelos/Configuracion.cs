using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
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

        public static string MostrarExcepcion(Exception ex)
        {
            StringBuilder sbMensaje = new StringBuilder();

            while (ex != null)
            {
                sbMensaje.AppendLine(ex.Message);
                ex = ex.InnerException;
            }

            return sbMensaje.ToString();
        }

        //Obtener Hash MD5
        public static string ObtenerMd5Hash(string input)
        {
            // Crear un Stringbuilder para colexionar los bytes y crear un nuevo string.
            StringBuilder sBuilder = new StringBuilder();

            using (MD5 md5Hash = MD5.Create())
            {
                // Convertir el string a un arreglo de bytes
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Ciclo a traves de cada byte para formar el string en Hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }

            // Regresar el String en Hexadecimal
            return sBuilder.ToString();
        }

        public static usuarios_app usuarioApp;
    }
}

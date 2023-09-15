using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuario
{
    public class Administrador
    {
        public Dictionary<string, string> diccionarioUsuarioContrasenia = new Dictionary<string, string>();

        public Administrador()
        {
            diccionarioUsuarioContrasenia["esteban"] = "1234";
            diccionarioUsuarioContrasenia["juan"] = "1235";
            diccionarioUsuarioContrasenia["papafrita"] = "123asd";


        }

        public static bool RegistrarAlumno()
        {
            if (true)
            {
                return true;
            }
            return false;

        }
    }
}
using Cursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeUsuario
{
    public class Estudiante : Usuario
    {
        public List<string> CursosInscritos { get; set; }

        public Estudiante()
        {

        }
        public Estudiante(string nombreCompleto, string documento, string direccion, string numeroTelefono,
                          string correo, string legajo, string contra, string tipoDeUsuario, List<string> cursos) : base(nombreCompleto,
                          documento, direccion, numeroTelefono, correo, legajo, contra, tipoDeUsuario)
        {
            NombreCompleto = nombreCompleto;
            DNI = documento;
            Direccion = direccion;
            NumeroTelefono = numeroTelefono;
            CorreoElectronico = correo;
            Legajo = legajo;
            Contrasenia = contra;
            TipoDeUsuario = tipoDeUsuario;
            CursosInscritos = cursos;
        }
    }
}

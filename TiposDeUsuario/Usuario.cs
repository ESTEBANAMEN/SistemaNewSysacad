using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TiposDeUsuario
{
    public class Usuario
    {
        public string? NombreCompleto { get; set; }
        public string? DNI { get; set; }
        public string? Direccion { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Legajo { get; set; }
        public string? Contrasenia { get; set; }
        public string? TipoDeUsuario { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nombreCompleto, 
                       string documento, 
                       string direccion, 
                       string numeroTelefono, 
                       string correo, 
                       string legajo, 
                       string contra, 
                       string tipoDeUsuario)
        {
            NombreCompleto = nombreCompleto;
            DNI = documento;
            Direccion = direccion;
            NumeroTelefono = numeroTelefono;
            CorreoElectronico = correo;
            Legajo = legajo;
            Contrasenia = contra;
            TipoDeUsuario = tipoDeUsuario;
        }
    }
}

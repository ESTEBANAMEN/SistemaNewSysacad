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
        public string? TipoDeUsuario { get; set; }

        private string _contraseniaHash;

        public string Contrasenia
        {
            get { return _contraseniaHash; }
            set { _contraseniaHash = Hash.GetHash(value); }
        }

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

    public class Hash
    {
        public static string GetHash(string password)
        {
            var hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);
            return hash;
        }

        public static bool ValidatePassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TiposDeUsuario
{
    public class Administrador : Usuario
    {
        private List<Usuario> listaDeUsuarios;

        public Administrador(string nombreCompleto, string documento, string direccion, string numeroTelefono,
                             string correo, string legajo, string contra, string tipoDeUsuario) :
                             base(nombreCompleto, documento, direccion, numeroTelefono, correo, legajo, contra, tipoDeUsuario)
        {
            NombreCompleto = nombreCompleto;
            DNI = documento;
            Direccion = direccion;
            NumeroTelefono = numeroTelefono;
            CorreoElectronico = correo;
            Legajo = legajo;
            Contrasenia = contra;
            TipoDeUsuario = tipoDeUsuario;

            listaDeUsuarios = new List<Usuario>();
        }

        public bool RegistrarAdministradorOEstudiante(Usuario usuario)
        {
            listaDeUsuarios = ReadStreamJSON("usuarios.json");
            bool usuarioExistente = false;

            if (listaDeUsuarios == null)
            {
                listaDeUsuarios = new List<Usuario>();
            }

            foreach (Usuario user in listaDeUsuarios)
            {
                if (user.DNI == usuario.DNI || user.CorreoElectronico == usuario.CorreoElectronico)
                {
                    usuarioExistente = true;
                    break;
                }
            }

            if (!usuarioExistente)
            {
                listaDeUsuarios.Add(usuario);
                WriteStreamJSON("usuarios.json", listaDeUsuarios);
            }

            return !usuarioExistente;
        }


    private static readonly string carpetaDeArchivos = @"C:\Users\steba\source\repos\TrabajoPractico\CarpetaDeArchivos";

        public static void WriteStreamJSON(string nombreDelArchivo, List<Usuario> usuarios)
        {
            string ruta = Path.Combine(carpetaDeArchivos, nombreDelArchivo);

            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonString = JsonSerializer.Serialize(usuarios, options);

                File.WriteAllText(ruta, jsonString);

                Console.WriteLine($"Se ha escrito el archivo JSON: {ruta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo JSON: {ex.Message}");
            }
        }

        public static List<Usuario>? ReadStreamJSON(string nombreDelArchivo)
        {
            string ruta = Path.Combine(carpetaDeArchivos, nombreDelArchivo);

            if (File.Exists(ruta))
            {
                using (var reader = new StreamReader(ruta))
                {
                    var json = reader.ReadToEnd();

                    List<Usuario>? usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
                    
                    return usuarios;
                }
            }
            else
            {
                List<Usuario> usuarios = new List<Usuario>();
                WriteStreamJSON(nombreDelArchivo, usuarios);
                return usuarios;
            }
        }
    } 
}
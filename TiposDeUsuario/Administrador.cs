using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Cursos;

namespace TiposDeUsuario
{
    public class Administrador : Usuario
    {
        private List<Usuario> listaDeUsuarios;
        private List<Curso> listaDeCursos;

        public Administrador()
        {

        }
        public Administrador(string nombreCompleto, string documento, string direccion, string numeroTelefono,
                             string correo, string legajo, string contra, string tipoDeUsuario) : base (nombreCompleto,
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

            listaDeUsuarios = new List<Usuario>();
            listaDeCursos = new List<Curso>();
        }

        public bool RegistrarAdministrador(Usuario usuario)
        {
            listaDeUsuarios = ReadStreamJSON<Usuario>("administradores.json");
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
                WriteStreamJSON("administradores.json", listaDeUsuarios);
            }

            return !usuarioExistente;
        }

        public bool RegistrarEstudiante(Usuario usuario)
        {
            listaDeUsuarios = ReadStreamJSON<Usuario>("estudiantes.json");
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
                WriteStreamJSON("estudiantes.json", listaDeUsuarios);
            }

            return !usuarioExistente;
        }

        public bool GestionarCurso(Curso curso)
        {
            listaDeCursos = ReadStreamJSON<Curso>("cursos.json");
            bool cursoExistente = false;

            if (listaDeCursos == null)
            {
                listaDeCursos = new List<Curso>();
            }

            foreach (Curso cursoEnLista in listaDeCursos)
            {
                if (curso.Nombre == cursoEnLista.Nombre || curso.Codigo == cursoEnLista.Codigo)
                {
                    cursoExistente = true;
                    break;
                }
            }

            if (!cursoExistente)
            {
                listaDeCursos.Add(curso);
                WriteStreamJSON<Curso>("cursos.json", listaDeCursos);
            }
            return !cursoExistente;
        }

        public static bool EnviarMail(string correo)
        {
            bool correoEnviado = true;

            if (correoEnviado)
            {
                return true;
            }
            return false;
        }

        private static readonly string carpetaDeArchivos = @"C:\Users\steba\source\repos\TrabajoPractico\CarpetaDeArchivos";

        public static void WriteStreamJSON<T>(string nombreDelArchivo, List<T> lista)
        {
            string ruta = Path.Combine(carpetaDeArchivos, nombreDelArchivo);

            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string jsonString = JsonSerializer.Serialize(lista, options);

                File.WriteAllText(ruta, jsonString);

                Console.WriteLine($"Se ha escrito el archivo JSON: {ruta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo JSON: {ex.Message}");
            }
        }

        public static List<T>? ReadStreamJSON<T>(string nombreDelArchivo)
        {
            string ruta = Path.Combine(carpetaDeArchivos, nombreDelArchivo);

            if (File.Exists(ruta))
            {
                using (var reader = new StreamReader(ruta))
                {
                    var json = reader.ReadToEnd();

                    List<T>? lista = JsonSerializer.Deserialize<List<T>>(json);

                    return lista;
                }
            }
            else
            {
                List<T> listaVacia = new List<T>();
                WriteStreamJSON(nombreDelArchivo, listaVacia);
                return listaVacia;
            }
        }

    }
}
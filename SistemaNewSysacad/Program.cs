using System.ComponentModel;
using TiposDeUsuario;
namespace SistemaNewSysacad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string tipoDeUsuario;

                Console.WriteLine("¡Bienvenido al nuevo sistema SYSACAD!\n" +
                    "Por favor ingrese el tipo de usuario:\n" +
                    "1- Administrador.\n" +
                    "2- Profesor.\n" +
                    "3- Estudiante.");

                tipoDeUsuario = Console.ReadLine();

                //Armar un while de validacion al tipo de usuario.

                switch (tipoDeUsuario)
                {
                    case "1":
                        string usuario;
                        string contraseia;
                        string ingreso = "";

                        while (true)
                        {
                            int contador = 0;
                            Console.WriteLine("Usuario:");
                            usuario = Console.ReadLine();

                            Console.WriteLine("Contraseña:");
                            contraseia = Console.ReadLine();

                            Administrador admin = new Administrador();
                            foreach (var diccionario in admin.diccionarioUsuarioContrasenia)
                            {
                                string clave = diccionario.Key;
                                string valor = diccionario.Value;

                                if (usuario == clave && contraseia == valor)
                                {
                                    contador = 0;
                                    ingreso = "coreccto";
                                    Console.WriteLine("DATOS CORRECTOS!\n");
   
                                    List<string> listaDeOpciones = new List<string>();
                                    listaDeOpciones.Add("Registrar Estudiante");
                                    listaDeOpciones.Add("Salir");

                                    Console.WriteLine(GeneradorDeMenu(listaDeOpciones));
                                }
                                else if (contador == admin.diccionarioUsuarioContrasenia.Count)
                                {
                                    Console.WriteLine("Error de usuario o contraseña. Desea ingresarlos nuevamente? (S/N)");
                                    ingreso = Console.ReadLine();
                                    if (ingreso == "S")
                                    {
                                        break;
                                    }
                                    else 
                                    {
                                        ingreso = "salir";
                                        break;
                                    }
                                    
                                }
                                contador++;
                            }
                            if (ingreso == "salir")
                            {
                                break;
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            }
        }

        private static string GeneradorDeMenu(List<string> listaDeOpciones)
        {
            string menu = "Menu de opciones para Administrador\n";
            int cantidadDeOpciones = listaDeOpciones.Count;

            for (int i = 0; i < cantidadDeOpciones; i++)
            {
                 string opcion = listaDeOpciones[i];
                menu += $"{i + 1}- {opcion}.\n";
            }
            return menu;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Menu
    {
        public List<Publicacion> Publicaciones { get; set; }

        public Menu()
        {
            Publicaciones = new List<Publicacion>();
        }

        /// <summary>
        /// Método para el menú principal
        /// </summary>
        /// <returns></returns>
        public void MostrarMenu()
        {
            try
            {
                Boolean salir = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenidos Digite el # de Usuario\n\n1- Editor\n2- Invitado\n3- Salir Programa");
                    int tipo = Int16.Parse(Console.ReadLine());
                    string nombre = "";
                    switch (tipo)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Digite su nombre completo: ");
                            nombre = Console.ReadLine();
                            MenuEditor(new Usuario(nombre, 1));
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Digite su nombre completo: ");
                            nombre = Console.ReadLine();
                            MenuInvitado(new Usuario(nombre, 2));
                            break;
                        case 3:
                            Console.Clear();
                            salir = true;
                            Console.WriteLine("Muchas gracias!");
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                } while (!salir);
            }
            catch (Exception e)
            {
                Console.WriteLine("Valor inválido");
            }
        }

        /// <summary>
        /// Método para el menú del editor
        /// </summary>
        /// <returns></returns>
        public void MenuEditor(Usuario usuario)
        {
            Boolean salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido Editor " + usuario.Nombrecompleto + "\n\n1- Nueva Publicación\n2- Mostrar Publicaciones\n3- Cerrar Sesión");
                int tipo = Int16.Parse(Console.ReadLine());
                switch (tipo)
                {
                    case 1:
                        Console.Clear();
                        Publicaciones.Add(LogicaPublicacion.NuevaPublicacion(usuario));
                        Console.WriteLine("Publicación agregada");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(LogicaPublicacion.ListaPublicaciones(Publicaciones));
                        Console.ReadKey();
                        break;
                    case 3:
                        salir = true;
                        Console.WriteLine("Muchas gracias!");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            } while (!salir);
        }

        /// <summary>
        /// Método para el menú del invitado
        /// </summary>
        /// <returns></returns>
        public void MenuInvitado(Usuario usuario)
        {
            Boolean salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido Invitado " + usuario.Nombrecompleto + "\n\n1- Nuevo Comentario\n2- Mostrar Publicaciones\n3- Cerrar Sesión");
                int tipo = Int16.Parse(Console.ReadLine());
                switch (tipo)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite el # de publicación que desea comentar");
                        int id = Int16.Parse(Console.ReadLine());
                        if (LogicaPublicacion.ExistePublicacion(id, Publicaciones))
                        {
                            Comentario comentario = LogicaComentario.NuevoComentario(usuario);
                            LogicaPublicacion.AgregarComentario(id, Publicaciones, comentario);
                        }
                        else
                        {
                            Console.WriteLine("Id de publicación no existe");
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(LogicaPublicacion.ListaPublicaciones(Publicaciones));
                        Console.ReadKey();
                        break;
                    case 3:
                        salir = true;
                        Console.WriteLine("Muchas gracias!");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            } while (!salir);
        }

    }
}

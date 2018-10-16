using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public static class LogicaPublicacion
    {

        /// <summary>
        /// Método para agregar una publicación
        /// </summary>
        /// <returns></returns>
        public static Publicacion NuevaPublicacion(Usuario usuario)
        {
            Console.WriteLine("Digite su publicación: ");
            string post = Console.ReadLine();
            return new Publicacion(post, usuario);
        }


        /// <summary>
        /// Método para mostrar todas las publicaciones
        /// </summary>
        /// <returns></returns>
        public static string ListaPublicaciones(List<Publicacion> publicaciones)
        {
            StringBuilder listado = new StringBuilder();

            if (publicaciones.Count == 0)
            {
                listado.Append("No hay publicaciones");
            }
            else
            {

                foreach (var Publicacion in publicaciones)
                {
                    listado.Append(Publicacion);
                    listado.Append("\n\n******************************************************************************************************\n\n");
                }
            }
            return listado.ToString();
        }

        /// <summary>
        /// Método para ver si existe el id de la publicación
        /// </summary>
        /// <returns></returns>
        public static Boolean ExistePublicacion(int id,List<Publicacion> publicaciones)
        {
            foreach (var Publicacion in publicaciones)
            {
                if (id == Publicacion.Id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para agregar un comentario a una publicación
        /// </summary>
        /// <returns></returns>
        public static void AgregarComentario(int id,List<Publicacion> publicaciones,Comentario comentario)
        {
            foreach (var Publicacion in publicaciones)
            {
                if (id == Publicacion.Id)
                {
                    Publicacion.Comentarios.Add(comentario);
                    Console.WriteLine("Comentario agregado");
                }
            }
   
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public static class LogicaComentario
    {
        /// <summary>
        /// Método para agregar un comentario
        /// </summary>
        /// <returns></returns>
        public static Comentario NuevoComentario(Usuario usuario)
        {
            Console.WriteLine("Digite su comentario: ");
            string post = Console.ReadLine();
            return new Comentario(post, usuario);
        }

        /// <summary>
        /// Método para mostrar todos los comentarios de una lista
        /// </summary>
        /// <returns></returns>
        public static string ListaComentarios(List<Comentario> comentarios)
        {
            StringBuilder listado = new StringBuilder();

            if (comentarios.Count == 0)
            {
                listado.Append("No tiene comentarios");
            }
            else
            {
                foreach (var Comentario in comentarios)
                {
                    listado.Append(Comentario);
                    listado.Append("\n-----------------------------------------------------------------------\n");
                }
            }

            return listado.ToString();
        } 



    }
}

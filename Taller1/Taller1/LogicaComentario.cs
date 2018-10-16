using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public static class LogicaComentario
    {

        public static Comentario nuevoComentario(Usuario usuario)
        {
            Console.WriteLine("Digite su comentario: ");
            string post = Console.ReadLine();
            return new Comentario(post, usuario);
        }

        public static string listaComentarios(List<Comentario> comentarios)
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
                    listado.Append("\n\n-----------------------------------------------------------------------\n\n");
                }
            }

            return listado.ToString();
        } 



    }
}

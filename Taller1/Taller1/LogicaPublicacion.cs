using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public static class LogicaPublicacion
    {

        public static Publicacion nuevaPublicacion(Usuario usuario)
        {
            Console.WriteLine("Digite su publicación: ");
            string post = Console.ReadLine();
            return new Publicacion(post, usuario);
        }


        public static string listaPublicaciones(List<Publicacion> publicaciones)
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

        public static Boolean existePublicacion(int id,List<Publicacion> publicaciones)
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

        public static void agregarComentario(int id,List<Publicacion> publicaciones,Comentario comentario)
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

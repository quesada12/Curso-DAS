using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Publicacion
    {
        public static int contador = 0;
        public int Id { get; set; }
        public string Post { get; set; }
        public string Fecha { get; set; }
        public Usuario Autor { get; set; }
        public List<Comentario> Comentarios { get; set; }

        public Publicacion(string post, Usuario autor)
        {
            Id = contador++;
            Post = post;
            Autor = autor;
            Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
            Comentarios = new List<Comentario>();
        }

        public override string ToString()
        {
            return "Publicación #"+Id+" el " + Fecha + "\n\n" + Post + "\n" + Autor +"\n\nComentarios:\n"+LogicaComentario.listaComentarios(Comentarios);
        }


    }
}

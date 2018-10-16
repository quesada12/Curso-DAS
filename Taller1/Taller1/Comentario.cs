using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Comentario
    {
        public string Post { get; set; }
        public string Fecha { get; set; }
        public Usuario Autor { get; set; }

        public Comentario (string post,Usuario autor)
        {
            Post = post;
            Autor = autor;
            Fecha = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        public override string ToString()
        {
            return "Comentario el " + Fecha + "\n" + Post + "\n" + Autor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Taller1
{
    public class Usuario
    {

        public string Nombrecompleto { get; set; }
        public int Tipo { get; set; }


        public Usuario (string nombrecompleto, int tipo)
        {
            Nombrecompleto = nombrecompleto;
            Tipo = tipo;
        }


        public override string ToString()
        {
            if (Tipo == 1)
            {
                return "Por: " + Nombrecompleto;
            }
            else
            {
                return "Por Invitado: " + Nombrecompleto;
            }
        }
    }
}

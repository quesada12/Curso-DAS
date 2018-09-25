using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cuenta
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }

        public override string ToString()
        {
            return "el monto de la tarjeta es: "+Monto;
        }

        public virtual string Vender(decimal valor)
        {
            return null;   
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Credito:Cuenta
    {
        public override string ToString()
        {
            return "Tarjeta de Crédito: "+base.ToString();
        }

        public override string Vender(decimal valor)
        {
            Monto = Monto - valor;
            return "El crédito fue realizado el monto actual de la cuenta es: " + Monto;
        }

      
    }
}

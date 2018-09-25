using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Debito : Cuenta
    {
        public override string ToString()
        {
            return "Tarjeta de Débito " + base.ToString();
        }

        public override string Vender(decimal valor)
        {
            string respuesta;
            if (valor <= 0)
            {
                respuesta = "El monto del debito es incorrecto";
            }
            else
            {
                decimal temp = Monto - valor;
                if (temp < 0)
                {
                    respuesta = "El monto no se puede debitar porque quedaría la cuenta en negativo";
                }
                else
                {
                    Monto = Monto - valor;
                    respuesta = "El débito se realizo exitosamente, el monto actual de la cuenta es: " + Monto;
                }
            }
            return respuesta;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Debito debito = new Debito()
            {
                Monto = 20000
            };

            Credito credito = new Credito()
            {
                Monto = 0
            };

            Boolean validador = false;
            decimal valor;
            do
            {
                Console.WriteLine("1- Método Vender\n2- Método ToString\n3- Salir");
                int opc = Int16.Parse(Console.ReadLine());
                int tipo = 0;
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Digite el valor: ");
                        valor = Decimal.Parse(Console.ReadLine());
                        tipo = PedirTipo();
                        if (tipo == 1)
                        {
                            Console.WriteLine(debito.Vender(valor));
                        }
                        else {
                            Console.WriteLine(credito.Vender(valor));
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        tipo = PedirTipo();
                        if (tipo == 1)
                        {
                            Console.WriteLine(debito);
                        }
                        else
                        {
                            Console.WriteLine(credito);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        validador = true;
                        Console.WriteLine("Gracias!");
                        Console.ReadKey();
                        break;

                }
            } while (!validador);


        }

        public static int PedirTipo()
        {
           
            Console.WriteLine("\nDigite el tipo de tarjeta: \n\n1-Débito\n2-Crédito");
            return Int16.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Práctica6_4
    {
        //Andrés Lemus 04/09/2019
        static void Main(string[] args)
        {
            bool rep = false;
            do
            {
                rep = false;
                Console.WriteLine("Ingrese el Número que desea convertir a Binario");
                if (decimal.TryParse(Console.ReadLine(), out decimal num) && num >= 0)
                {
                    Console.WriteLine("Número {0} en el Sistema Binario: {1}", num, convBinario(num));
                }
                else
                {
                    Console.WriteLine("Tiene que ser un número positivo :C");
                    rep = true;
                }
            } while (rep == true);
        }

        public static string convBinario(decimal n)
        {
            if (n <= 0)
            {
                string binario = "0";
                return binario;
            }
            else
            {
                string binario = "";
                decimal div = Math.Truncate(Convert.ToDecimal(convBinario(n - div)) / 2);
                int res = Convert.ToInt32(convBinario(n - div)) % 2;
                binario += res;
                return binario;
            }
        }
    }
}

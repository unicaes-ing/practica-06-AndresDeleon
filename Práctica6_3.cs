using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Práctica6_3
    {
        //Andrés Lemus 04/09/2019
        static void Main(string[] args)
        {
            bool rep = false;
            do
            {
                rep = false;
                Console.WriteLine("Ingrese el número base del exponente");
                if (int.TryParse(Console.ReadLine(),out int b))
                {
                    rep = false;
                    Console.WriteLine("Ingrese el valor del exponente");
                    if (int.TryParse(Console.ReadLine(), out int e))
                    { 
                        Console.WriteLine("Resultado: " + exponencial(b, e));
                    }
                    else
                    {
                        Console.WriteLine("Tiene que ser un número :C");
                        rep = true;
                    }
                }
                else
                {
                    Console.WriteLine("Tiene que ser un número :C");
                    rep = true;
                }
            } while (rep == true);
            Console.ReadKey();
        }

        public static int exponencial(int bas, int exp)
        {
            if (exp <= 0)
            {
                return 1;
            }
            else
            {
                int resultado = bas * exponencial(bas, (exp - 1));
                return resultado;
            }
        }
    }
}

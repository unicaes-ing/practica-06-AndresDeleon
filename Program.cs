using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Práctica_6
{
    class Práctica6_1
    {
        //Andrés Lemus 04/09/2019
        static void Main(string[] args)
        {
            bool rep = false;
            do
            {
  
            Console.WriteLine("Ingrese el número de que desea la tabla de multiplicar");
                if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
                {
                    tabla(num);
                    Console.WriteLine("Ingrese el color que desea agregar");
                    string c = Console.ReadLine();
                    tabla(num, c);
                }
                else
                {
                    Console.WriteLine("Tiene que ser un número positivo :(");
                    rep = true;
                }
            } while (rep == true);
            Console.ReadKey();
        }

        static void tabla(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }

        static void tabla(int n, string c)
        {
            foreach (var color in Enum.GetValues(typeof(ConsoleColor)))
            {
                if (Convert.ToString(color) == c)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            }
            Console.Clear();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }
    }
}

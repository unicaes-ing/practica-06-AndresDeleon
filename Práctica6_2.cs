using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_6
{
    class Práctica6_2
    {
        //Andrés Lemus 04/09/2019
        static void Main(string[] args)
        {
            bool rep = false;
            do
            {
                rep = false;
                Console.WriteLine("Ingrese el ancho de la figura");
                if (int.TryParse(Console.ReadLine(), out int w) && w > 0)
                {
                    Console.WriteLine("Ingrese la altura dela figura");
                    if (int.TryParse(Console.ReadLine(), out int h) && h > 0)
                    {
                        Dibujo(w, h);
                        Console.WriteLine("Ingrese el caracter a utilizar");
                        string c = Console.ReadLine();
                        Dibujo(w, h, c);
                        Console.WriteLine("Ingrese la posición en X");
                        if (int.TryParse(Console.ReadLine(), out int x))
                        {
                            Console.WriteLine("Ingrese la posición en Y");
                            if (int.TryParse(Console.ReadLine(), out int y))
                            {
                                Dibujo(w, h, c, x, y);
                            }
                            else
                            {
                                Console.WriteLine("Tiene que ser un entero :C");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tiene que ser un entero :C");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tiene que ser un entero positivo :C");
                        rep = true;
                    }
                }
                else
                {
                    Console.WriteLine("Tiene que ser un entero positivo :C");
                    rep = true;
                }
            } while (rep == true);
            Console.ReadKey();
        }

        public static void Dibujo(int ancho, int alto)
        {
            Console.Clear();
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == (alto - 1))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        if (j == 0 || j == (ancho - 1))
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Dibujo(int ancho, int alto, string caracter)
        {
            Console.Clear();
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == (alto - 1))
                    {
                        Console.Write(caracter + " ");
                    }
                    else
                    {
                        if (j == 0 || j == (ancho - 1))
                        {
                            Console.Write(caracter + " ");
                        }
                        else
                        {
                            for (int q = 0; q < caracter.Length; q++)
                            {
                                Console.Write("  ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Dibujo(int ancho, int alto, string caracter, int x, int y)
        {
            Console.Clear();
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (i == 0 || i == (alto - 1))
                    {
                        Console.SetCursorPosition((x + j), (y + i)); Console.Write(caracter + " ");
                    }
                    else
                    {
                        if (j == 0 || j == (ancho - 1))
                        {
                            Console.SetCursorPosition((x + j), (y + i)); Console.Write(caracter + " ");
                        }
                        else
                        {
                            for (int q = 0; q < caracter.Length; q++)
                            {
                                Console.SetCursorPosition((x + j), (y + i)); Console.Write("  ");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

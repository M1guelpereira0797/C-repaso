using System;
using System.Collections.Generic;


namespace Diccionario07_08_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Producto = new Dictionary<string, int>();
            int totalFinal = 0;
            Console.WriteLine("Que producto desea comprar: ");
            string Producto_Vendido = Console.ReadLine();
            
            switch (Producto_Vendido.ToLower())
            {
                case "bebida":
                    Console.WriteLine("Cuantas bebidas se va a llevar: ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= Cantidad; i++)
                    {
                        Console.WriteLine("Ingrese que bebida es: ");
                        string Bebida = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio: ");
                        int Precio = Convert.ToInt32(Console.ReadLine());
                        Producto.Add(Bebida, Precio);
                        int subtotal = SumaBebida(1, Precio);
                        totalFinal += subtotal;

                        
                    }
                    break;
            }
            foreach(var n in Producto)
            {
                Console.WriteLine($" Producto: {n.Key} / Precio: {n.Value} ");
                
            }
            Console.WriteLine($"Total a pagar es:{totalFinal}");
        }

        static int SumaBebida(int Cantidad, int Precio)
        {
            int suma = Precio * Cantidad;
            return suma;

        }
    }
}


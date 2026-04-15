using System;
using Tarea1;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "sí";

            while (continuar.ToLower() == "sí" || continuar.ToLower() == "si")
            {
                Console.Clear();
                Console.WriteLine("--- Calculadora de Figuras Geométricas ---");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Ingrese la base: ");
                    float b = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    float h = float.Parse(Console.ReadLine());

                    rectangulo rect = new rectangulo(b, h);
                    Console.WriteLine($"Área: {rect.CalcularArea()}");
                    Console.WriteLine($"Perímetro: {rect.CalcularPerimetro()}");
                }
                else if (opcion == "2")
                {
                    Console.Write("Ingrese el radio: ");
                    float r = float.Parse(Console.ReadLine());

                    circulo circ = new circulo(r);
                    Console.WriteLine($"Área: {circ.CalcularArea()}");
                    Console.WriteLine($"Perímetro: {circ.CalcularPerimetro()}");
                }
                else if (opcion == "3")
                {
                    Console.Write("Ingrese la base: ");
                    float b = float.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    float h = float.Parse(Console.ReadLine());

                    triangulo tri = new triangulo(b, h);
                    Console.WriteLine($"Área: {tri.CalcularArea()}");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }

                Console.WriteLine("\n¿Desea continuar? ('sí' o 'no')");
                continuar = Console.ReadLine();
            }

            
        }
    }
}
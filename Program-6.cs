using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Calcular el área de un círculo, dado su radio (pi * radio al cuadrado).
            double area;
            double radio;
            Console.WriteLine("Introducir el radio del circulo: ");
            radio = double.Parse(Console.ReadLine());
            area = Math.PI * Math.Pow(radio, 2);
            Console.WriteLine("El area del circulo es: " + area);
            Console.ReadKey();
        }
    }
}

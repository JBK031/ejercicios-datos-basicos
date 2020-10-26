using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2.Pedir al usuario dos números enteros largos ("long") y mostrar su suma, su resta y su producto.
             */

            long num1;
            long num2;
            long suma;
            long resta;
            long producto;
            Console.WriteLine("Introducir el primer numero entero largo: ");
            num1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Introducir el segundo numero entero largo: ");
            num2 = long.Parse(Console.ReadLine());

            suma = num1 + num2;
            resta = num1 - num2;
            producto = num1 * num2;

            Console.WriteLine("El resulatdo de la suma de los dos numeros enteros largos es: " + suma);
            Console.WriteLine("El resulatdo de la resta de los dos numeros enteros largos es: " + resta);
            Console.WriteLine("El resulatdo de la producto de los dos numeros enteros largos es: " + producto);
            Console.ReadKey();
        }
    }
}

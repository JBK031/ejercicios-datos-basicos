using System;


namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. un programa que use tres variables x,y,z. Sus valores iniciales serán 15, -10, 2.147.483.647. 
             * Se deberá incrementar tres vece el valor de estas variables. 
             * Mostrar en pantalla el valor incial de las variables y el valor final obtenido por el programa.
             */

            long x = 15;
            long y = -10;
            double z =2.147483647;

            Console.WriteLine("El valor inicial que tiene la variable x es: " + x);
            Console.WriteLine("El valor inicial que tiene la variable y es: " + y);
            Console.WriteLine("El valor inicial que tiene la variable z es: " + z);

            double r1;
            double r2;
            double r3;
            r1 = Math.Pow(x,3);
            r2 = Math.Pow(y,3);
            r3 = Math.Pow(z, 3);

            Console.WriteLine("El valor final obtenido por el programa es: " + r1);
            Console.WriteLine("El valor final obtenido por el programa es: " + r2);
            Console.WriteLine("El valor final obtenido por el programa es: " + r3);

            Console.ReadKey();
        }
    }
}

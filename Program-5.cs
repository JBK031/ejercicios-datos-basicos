using System;

namespace Programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;
             */
            int a;
            int b;
            int c;

            a = 5;
            b = a + 2;
            b -= 3;
            c = -3;
            c *= 2;
            ++c;
            a *= b;

            Console.WriteLine("El resultado de a es: " + a);
            Console.WriteLine("El resultado de b es: " + b);
            Console.WriteLine("El resultado de c es: " + c);
            Console.ReadKey();
        }
    }
}

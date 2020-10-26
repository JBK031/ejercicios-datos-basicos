using System;

namespace Programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5; a=a*2;
             */
            int a;
            int b;
            int c;

            a = 5;
            b = ++a;
            c = a++;
            b = b * 5;
            a = a * 2;

            Console.WriteLine("Resultado de a: " + a);
            Console.WriteLine("Resultado de b: " + b);
            Console.WriteLine("Resultado de c: "+c);
        }
    }
}

using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Preguntar al usuario su edad, que se guardará en un "byte". 
             * A continuación, se deberá le deberá decir que no aparenta tantos años (por ejemplo, "No aparentas 20 años").
             */

            byte años;

            Console.WriteLine("Introducir su edad: ");
            años = byte.Parse(Console.ReadLine());
            Console.WriteLine("No aparentas tener " + años + " años");
            Console.ReadKey();
        }
    }
}

using System;

namespace Programa_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*7.Crear un programa que pida al usuario a una distancia (en metros) y 
             * el tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), 
             * y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas por hora (pista: 1 milla = 1.609 metros).
             */

            double metro;
            double km;
            double milla;
            double horas;
            double min;
            double segundo;
            double rvm;
            double rvk;
            double rvmm;
            Console.WriteLine("Introducir la distancia (en metro): ");
            metro = long.Parse(Console.ReadLine());
            Console.WriteLine("Debe introducir el tiempo que le tomara");
            Console.WriteLine("Horas:");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Minutos:");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundos:");
            segundo = long.Parse(Console.ReadLine());
            rvm = metro / ((horas * 3600) + (min * 60) + segundo);
            rvk = (metro / 1000) / (horas+(min/60)+(segundo/3600));
            rvmm=(metro/1609)/ (horas + (min / 60) + (segundo / 3600));
            Console.WriteLine("La velocidad en metro es:" + rvm+ "Por segundo" );
            Console.WriteLine("La velocidad en kilometro es:" + rvk+ "Por hora");
            Console.WriteLine("La velocidad en milla es:" + rvmm+ "Por hora");
        }
    }
}

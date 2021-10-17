using System;

namespace projeto_km
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double consumo;

            Console.WriteLine("Informe a distancia que sera percorrida");
            distancia = int.Parse(Console.ReadLine());

            consumo = distancia /10.00;

            Console.WriteLine("A quantidade de combustivel é:{0:N} ", consumo);

        }
    }
}

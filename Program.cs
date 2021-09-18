using System;

namespace GrauCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em graus °C para coverter: ");
            string valordoGrau = Console.ReadLine();
            double numerodoGrau = Double.Parse(valordoGrau);

            double resultadodoGrau = (numerodoGrau*1.8)+32;

            Console.WriteLine();

            Console.WriteLine("°C = " + numerodoGrau);
            Console.WriteLine(numerodoGrau + "°C equivale a " + resultadodoGrau + "°F");
        }
    }
}

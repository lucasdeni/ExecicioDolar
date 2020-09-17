using System;
using System.Globalization;

namespace Dólar
{
    class Program
    {
        static void Main(string[] args)
        {
            CotaçãoDolar c = new CotaçãoDolar();
            Console.WriteLine("Qual é a cotação do dolar? ");
            double Cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você irá comprar? ");
            double Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Reais = Cotação * Dolar;
            double total = c.TotalEmReais(Reais);
            
            Console.WriteLine("Valor a ser pago em reais: " + total.ToString("F2" ,CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}

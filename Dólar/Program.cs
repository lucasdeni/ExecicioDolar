using System;
using System.Globalization;

namespace Dólar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar? ");
            CotaçãoDolar.cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você irá comprar? ");
            CotaçãoDolar.dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = CotaçãoDolar.TotalEmReais();
            
            Console.WriteLine("Valor a ser pago em reais: " + total.ToString("F2" ,CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}

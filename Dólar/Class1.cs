using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Dólar
{
    class CotaçãoDolar
    {
        public static double iof = 0.06;
        public static double cotacao;
        public static double dolar;

        public static double TotalEmReais()
        {
            return ((cotacao * dolar) * iof) + (cotacao * dolar);
        }
    }
}

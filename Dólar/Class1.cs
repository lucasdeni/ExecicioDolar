using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Dólar
{
    class CotaçãoDolar
    {
        public static double iof = 0.06;
        public double Reais;

        public double TotalEmReais(double total)
        {
            return (total * iof) + total;
        }
    }
}

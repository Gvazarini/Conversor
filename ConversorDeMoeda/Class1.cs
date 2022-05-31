using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda 
{
     class Conversor
    {
        public static double IOF = 0.06;
        public  double DolarParaReal(double quantia, double valormoeda)
        {
            double valor = quantia * valormoeda;
             return (valor * IOF) + valor;
        }
      
     }
}

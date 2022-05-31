using System.Globalization;
using ConversorDeMoeda;
namespace ProjConvert

{
    class Program
    {
        static void Main(string[] args)
        {
            Conversor convert = new Conversor();
            Console.WriteLine("Qual o valor da moeda desejada hoje? : ");
            double valormoeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a quantia que deseja comprar?: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double result  = convert.DolarParaReal(valormoeda, quantia);
            Console.WriteLine("O valor total a ser pago com IOF e de : " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

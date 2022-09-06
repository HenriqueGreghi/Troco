using System;
using System.Globalization;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas valor = new Notas();

            Console.WriteLine("Entre com o valor: ");

            valor.valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valor.Calculo();
            valor.Imprimir();
        }
    }
}

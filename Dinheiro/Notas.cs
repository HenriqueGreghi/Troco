using System;
using System.Globalization;

namespace Dinheiro
{
    class Notas
    {
        private double nota100;
        private double nota50;
        private double nota20;
        private double nota10;
        private double nota5;
        private double nota2;
        private double moeda100;
        private double moeda50;
        private double moeda25;
        private double moeda10;
        private double moeda5;
        private double moeda1;
        public double valor;

        public void Calculo()
        {
            if (valor >= 100)
            {
                nota100 =(int) (valor / 100);
                valor = valor % 100;
            }
            if ( valor <100 && valor >= 50)
            {
                nota50 = (int)valor / 50;
                valor = valor % 50;
            }
            if (valor < 50 && valor >= 20)
            {
                nota20 = (int)valor / 20;
                valor = valor % 20;
            }
            if (valor < 20 && valor >= 10)
            {
                nota10 = (int)valor / 10;
                valor = valor % 10;
            }
            if (valor < 10 && valor >= 5)
            {
                nota5 = (int)valor / 5;
                valor = valor % 5;
            }
            if (valor < 5 && valor >= 2)
            {
                nota2 = (int)valor / 2;
                valor = valor % 2;
            }
            if (valor < 2 && valor >= 1)
            {
                moeda100 = (int)(valor / 1);
                valor = valor % 1;
            }
            if (valor < 1 && valor >= 0.50)
            {
                moeda50 = (int)(valor / 0.50);
                valor = valor % 0.50;
            }
            if (valor < 0.50 && valor >= 0.25)
            {
                moeda25 = (int)(valor /0.25);
                valor = valor % 0.25;
            }
            if (valor < 0.25 && valor >= 0.10)
            {
                moeda10 = (int)(valor / 0.10);
                valor = valor % 0.10;
            }
            if (valor < 0.10 && valor >= 0.05)
            {
                moeda5 = (int)(valor / 0.05);
                valor = valor % 0.05;
            }
            if (valor < 0.05 && valor >= 0.01)
            {
                moeda1 = (int)(valor / 0.01);
                
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("Notas: ");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");
            Console.WriteLine("Moedas: ");
            Console.WriteLine(moeda100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 0.01");
        }
    }
}

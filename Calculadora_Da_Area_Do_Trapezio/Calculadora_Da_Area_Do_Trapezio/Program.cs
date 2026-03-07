using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Da_Area_Do_Trapezio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o valor da base maior: ");
            double base_maior = double.Parse(Console.ReadLine());

            Console.Write("digite o valor da base menor: ");
            double base_menor = double.Parse(Console.ReadLine());

            Console.Write("digite o valor da altura do trapézio: ");
            double altura = double.Parse(Console.ReadLine());

            double area = ((base_maior + base_menor) * altura) / 2; //Otimização da fórmula para calcular a área do trapézio, evitando a necessidade de variáveis intermediárias.
            //double soma_altura = altura * soma_base;
            //double area = soma_altura / 2;

            Console.Write($"A área do trapézio é: {area}");
        }
    }
}

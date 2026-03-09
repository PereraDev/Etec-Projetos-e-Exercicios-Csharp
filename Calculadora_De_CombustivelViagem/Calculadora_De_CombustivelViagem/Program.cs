using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_De_CombustivelViagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bem Vindo a Calculadora de Combustivel para Viagem! ---");

            //Console.WriteLine("Digite a distâcia percorrida:");
            Console.Write("Digite a distância percorrida (em km): ");
            double distancia = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor do combustivel:");
            //double valorC = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor médio do combustivel (km/l): ");
            double consumo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o consumo:");
            //double consumo = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do combustível (por litro): ");
            double valorCombustivel = double.Parse(Console.ReadLine());

            //double total = ((distancia / consumo) * valorC);
            //Console.WriteLine("O Total da viagem é :" + total);

            double totalGasto = ((distancia / consumo) * valorCombustivel);
            Console.WriteLine($"\nO custo total da viagem será de: {totalGasto:C}");
        }
    }
}

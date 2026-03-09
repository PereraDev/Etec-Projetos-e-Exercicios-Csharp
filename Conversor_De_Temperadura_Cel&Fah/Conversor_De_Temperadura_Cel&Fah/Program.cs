using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_De_Temperadura_Cel_Fah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheith:");
            //double fah = double.Parse(Console.ReadLine());
            double fahrenheith = double.Parse(Console.ReadLine());

            //double cel = (fah - 32) / 1.8;
            //Console.WriteLine("A temperatura em Celsius é: " + cel.ToString("N"));
            double celsius = (fahrenheith - 32) / 1.8;
            Console.WriteLine($"A temperatura em Celsius é: {celsius:N2}°C");
        }
    }
}

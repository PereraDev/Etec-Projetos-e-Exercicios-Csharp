using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda_Para_Restaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Antigo código para calcular a comanda de um restaurante, agora comentado para ser utilizado como referência futura.
            //Console.WriteLine("Informe o valor da comida, bebida e sobremesa:");
            //double comida = Convert.ToDouble(Console.ReadLine());
            //double bebida = Convert.ToDouble(Console.ReadLine());
            //double sobremesa = Convert.ToDouble(Console.ReadLine());
            //double total = comida + bebida + sobremesa;
            //Console.WriteLine("O valor total da comanda é: " + total.ToString("C"));
            //Console.WriteLine("Informe quantas pessoas estão dividindo a conta:");
            //int pessoas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("O valor que cada pessoa deve pagar é: " + (total / pessoas).ToString("C"));

            // Novo código para calcular a comanda de um restaurante, utilizando uma abordagem mais estruturada e orientada a objetos.
            Console.WriteLine("Bem-vindo ao sistema de comanda do restaurante!");

            Console.Write("Informe o valor gasto com comida: ");
            double comida = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor gasto com bebida: ");
            double bebida = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor gasto com sobremesa: ");
            double sobremesa = Convert.ToDouble(Console.ReadLine());

            double totalConta = comida + bebida + sobremesa;

            Console.WriteLine($"\nO valor total da comanda é: {totalConta:C}\n");

            Console.Write("Alguém vai pagar a conta? (S/N): ");
            string pagarSozinho = Console.ReadLine() .ToUpper();

            if (pagarSozinho == "S")
            {
                Console.WriteLine($"\nValor total a ser pago por essa pessoa é: {totalConta:C}");
            }
            else 
            { 
               Console.Write("Informe quantas pessoas estão dividindo a conta: ");
               int pessoas = Convert.ToInt32(Console.ReadLine());

                if (pessoas > 0)
                {
                   double valorPorPessoa = totalConta / pessoas;
                    Console.WriteLine($"\nO valor que cada pessoa deve pegar é { valorPorPessoa:C}");
                }
                else
                {
                    Console.WriteLine("\nEro: A conta precisa ser dividida por pelo menos 1 pessoas");

                }
        }
        }
    }
}

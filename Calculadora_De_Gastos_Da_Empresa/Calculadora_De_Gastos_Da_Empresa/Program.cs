using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_De_Gastos_Da_Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Código antigo para calcular os gastos da empresa e o lucro, comentado para evitar erros de execução, pois não há validação de entrada de dados.
            //Console.WriteLine("Digite os valores gasto pela empresa como aluguel, água, luz, telefone, internet e salario: ");
            //double aluguel = double.Parse(Console.ReadLine());
            //double agua = double.Parse(Console.ReadLine());
            //double luz = double.Parse(Console.ReadLine());
            //double telefone = double.Parse(Console.ReadLine());
            //double internet = double.Parse(Console.ReadLine());
            //double salario = double.Parse(Console.ReadLine());

            //double gasto = aluguel + agua + luz + telefone + internet + salario;

            //Console.WriteLine("O gasto total da empresa é: " + gasto.ToString("C"));

            //Console.WriteLine("Informe o valor das vendas do mês:");
            //double vendas = double.Parse(Console.ReadLine());

            //double lucro = vendas - gasto;
            //Console.WriteLine("O lucro da empresa é: " + lucro.ToString("C"));

            // Código atualizado para calcular os gastos da empresa e o lucro, com validação de entrada de dados.
            Console.WriteLine("--- Calculadora de Fechamento Mensal ---");

            Console.Write("Digite o valor gasto com Aluguel: ");
            double aluguel = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor gasto com Água: ");
            double agua = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor gasto com Luz: ");
            double luz = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor gasto com Telefone: ");
            double telefone = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor gasto com Internet: ");
            double internet = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor gasto com Salario: ");
            double salario = double.Parse(Console.ReadLine());

            double gastoTotal = aluguel + agua + luz + telefone + internet + salario;

            Console.WriteLine($"O gasto total da empresa é: {gastoTotal:C}\n");

            Console.Write("Informe o valor das vendas do mês: ");
            double vendas = double.Parse(Console.ReadLine());

            double resultadoFinanceiro = vendas - gastoTotal;

            if (resultadoFinanceiro > 0)
            { 
              Console.WriteLine($"\nParabéns! A empresa teve um LUCRO de: {resultadoFinanceiro:C}");
            }
            else if (resultadoFinanceiro < 0)
            {
                Console.WriteLine($"\nAtenção! A empresa teve um PREJUÍZO de: {resultadoFinanceiro:C}");
            }
            else
            {
                Console.WriteLine("\nA empresa ficou no ZERO A ZERO, sem lucro e sem prejuízo.");
            }
        }
    }
}

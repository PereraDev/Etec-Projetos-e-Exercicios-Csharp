using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento_De_Salario_No_Mes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Antigo código para calcular o aumento salarial de um funcionário, onde o usuário digita o salário bruto e o percentual de aumento, e o programa calcula o valor do aumento salarial e exibe para o usuário.
            //Console.WriteLine("Digite o salário bruto do funcionário:");
            //double salarioBruto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o percentual de aumento salarial:");
            //double percentualAumento = double.Parse(Console.ReadLine());
            //double desconto_porcentagem = (percentualAumento / salarioBruto);
            //Console.WriteLine("O valor do aumento salarial é: " + desconto_porcentagem.ToString("P"));

            // Novo código para calcular o aumento salarial de um funcionário, onde o usuário digita o salário bruto e o percentual de aumento, e o programa calcula o valor do aumento salarial e exibe para o usuário.
            Console.Write("Digite o salário bruto do funcionário: ");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de aumento salarial (ex: 10 para 100%): ");
            double percentualAumento = double.Parse(Console.ReadLine());

            double valorAumento = salarioBruto * (percentualAumento / 100);
            double novoSalario = salarioBruto + valorAumento;

            Console.WriteLine($"\nO valor do aumento salarial é de: {valorAumento:C}");
            Console.WriteLine($"O novo salário bruto sera de: {novoSalario:C}");


        }
    }
}

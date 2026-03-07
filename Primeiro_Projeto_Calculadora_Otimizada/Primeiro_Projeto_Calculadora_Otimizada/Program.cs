using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Projeto_Calculadora_Otimizada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");

            double n1 = double.Parse(Console.ReadLine());

            //string um = "+";

            //string dois = "-";

            //string tres = "*";

            //string quatro = "/";

            //Console.WriteLine("Selecione a operação: " + um + ", " + dois + ", " + tres + ", " + quatro + "");
            Console.WriteLine("Selecione a operação: +, -, *, /");

            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor:");

            double n2 = double.Parse(Console.ReadLine());

            double resultado = 0;
            bool operacaoValida = true;

            switch (operacao)

            {
                case "+":
                    resultado = n1 + n2;

                    break;

                case "-":
                    resultado = n1 - n2;

                    break;

                case "*":
                    resultado = n1 * n2;

                    break;

                case "/":

                    if (n2 != 0)
                    {
                        resultado = n1 / n2;
                    }

                    else
                    {
                        Console.WriteLine("Erro: Não é possível dividir por zero.");
                        operacaoValida = false;
                    }

                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    operacaoValida = false;
                    break;
            }
            if (operacaoValida)
            {
                Console.WriteLine($"O resultado é: { resultado}");
            }
        }
    }
}

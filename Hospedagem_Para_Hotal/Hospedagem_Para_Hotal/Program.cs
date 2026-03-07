using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_Para_Hotal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Me informe o valor da diária do hotel: ");
            //double valord = double.Parse(Console.ReadLine());
            double valorDiaria = double.Parse(Console.ReadLine());

            Console.Write("Me informe a quantidade de adultos: ");
            int adultos = int.Parse(Console.ReadLine());

            Console.Write("Me informe a quantidade de criança: ");
            int crianca = int.Parse(Console.ReadLine());

            //Calculando o valor diário (crianças pagam meia)
            //double porfam = valord * adultos + (valord * crianca) / 2;
            //Console.WriteLine(" O valor por dia da familia: " + porfam.ToString("C"));
            double valorDiarioFamilia = (valorDiaria * adultos) + ((valorDiaria / 2) * crianca);
            Console.Write($" O valor por dia da familia: {valorDiarioFamilia:C} \n");

            Console.Write(" Me informe a quantidade de dias de hospedagem: ");
            int dias = int.Parse(Console.ReadLine());

            //Armezando o total para não precisar calcular novamente
            //Console.WriteLine(" O valor total da hospedagem é: " + (porfam * dias).ToString("C"));
            double valorTotal = valorDiarioFamilia * dias;
            Console.Write($" O valor total da hospedagem é: {valorTotal:C} \n");

            Console.Write(" Me informe a quantidade de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            //Console.WriteLine(" O valor de cada parcela é: " + ((porfam * dias) / parcelas).ToString("C"));
            double valorParcela = valorTotal / parcelas;
            Console.Write($" O valor de cada parcela é: {valorParcela:C} \n");
        }
    }
}

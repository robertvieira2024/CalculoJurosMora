using System;

namespace CalculoJurosMora
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Solicita a data de vencimento do aluguel
            Console.Write("qual é a data do aluguel atrasado: ");

            //Registrando e armazenando o dia atual, para cálculos futuros
            DateTime hoje = DateTime.Now;

            //Convertendo para DateTime
            DateTime diaVencimento = Convert.ToDateTime(Console.ReadLine());

            //Armazenando percentual de juros nas variáveis
            double juros1 = 10.00;
            double juros2 = 0.10;

            //Solicita o valor do aluguel 
            Console.Write("valor do aluguel: r$");

            // Convertendo String valor do aluguel para Double
            double valorAluguel = Convert.ToDouble(Console.ReadLine());

            // Calculando dia atual até dia do vencimento e imprimindo na tela - calculando somente o dia s/ mês ano com a função Days
            Console.WriteLine($"dias atrasados: {hoje.Subtract(diaVencimento).Days}");
            int diasAtrasados = hoje.Subtract(diaVencimento).Days;

            //Calculando Juros diário
            double jurosPordia = (juros2 * valorAluguel) / 100 * diasAtrasados;

            //Calculando Multa do primeiro dia de atraso
            double atrasoDia = (juros1 * valorAluguel) / 100;

            // Calculando Juros por atraso mais Juros Dias
            double totalJuros = jurosPordia + atrasoDia;

            // Calculando Valor Alguel mais o total de Juros
            double valorTotal = valorAluguel + totalJuros;

            //Imprimindo Cálculos
            Console.WriteLine($"o total do juros dia é: r$ {jurosPordia}");
            Console.WriteLine($"o total do juros multa é: r$ {atrasoDia}");
            Console.WriteLine($"o total de juros a ser pago é: r$ {jurosPordia + atrasoDia}");
            Console.WriteLine($"total a ser pago: r$ {valorTotal}");

        }


    }
}      
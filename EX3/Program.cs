using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            Console.Write("Digite o Dia do seu aniversário: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Mês do seu aniversário: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Ano do seu aniversário: ");
            ano = Convert.ToInt32(Console.ReadLine());

            if (dia < 1 || dia > 31 || mes < 1 || mes > 12 || ano > 2020)
            {
                Console.WriteLine("Data inválida");
            }
            else
            {
                Console.WriteLine("Data válida");
            }
        }
    }
}

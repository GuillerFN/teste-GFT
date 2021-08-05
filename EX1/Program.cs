using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            do
            {
                Console.Write("Digite um valor com 4 dígitos: ");
                string[] valor = Console.ReadLine().Split(' ');
                int a = Int32.Parse(valor[0]);
                int b = Int32.Parse(valor[1]);
                int c = Int32.Parse(valor[2]);
                int d = Int32.Parse(valor[3]);
                int par = 0;

                if (a % 2 == 0)
                    par++;
                    
                if (b % 2 == 0)
                    par++;

                if (c % 2 == 0)
                    par++;

                if (d % 2 == 0)
                    par++;
 
                Console.WriteLine($"A quantidade de números pares é {par}");

                Console.WriteLine("Deseja continuar? (S/N)");
                resp = Console.ReadLine();
            } while (resp.ToUpper() == "S");
        }
    }
}

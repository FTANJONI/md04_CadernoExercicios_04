using System;

namespace md04_CadernoExercicios_04
{
    class Program
    {
        /*
         4. Faça um algoritmo que leia um conjunto de números e imprima sua soma
            (Soma) e sua média (Media). Admita que o valor 9999 é utilizado como fim de
            leitura.
            Ex.: 1, 2, 3, 9999 => Soma=6 Media=2

         */
        static void Main(string[] args)
        {
            int i = 0, nrDig, soma = 0, media, s = 2;
            do
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número;");
                nrDig = Convert.ToInt32(Console.ReadLine());
                soma = soma + nrDig;
                if ((i % 2) == 0 && i != 0)
                {
                    Console.WriteLine("Para calcular digite (1) ou (2) para adicionar mais números");
                    s = Convert.ToInt32(Console.ReadLine());
                }

                if (s < 1 && s > 2)
                {
                    Console.WriteLine("\nOpção Inválida!\nPor favor, digite (1) para sair, ou (2) para continuar.\n");
                }

                i++;
            } while (s == 2);
            media = soma / i;
            Console.WriteLine("\nSoma = {0} \nMédia = {1} {2} ", soma.ToString("0,0"), media.ToString("0,0")," 9999");
        }
    }
}

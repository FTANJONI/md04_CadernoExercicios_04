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
            int i = 0, n1 = 0, n2 = 0, n3 = 0, soma = 0, media;

            do
            {
                Console.WriteLine("Digite o " + (i + 1) + "° número;");
                if (i == 0)
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                }
                else if (i == 1)
                {
                    n2 = Convert.ToInt32(Console.ReadLine());
                }
                else if (i == 2)
                {
                    n3 = Convert.ToInt32(Console.ReadLine());
                }

                i++;
            } while (i <= 2);
           // i--;
            soma = n1 + n2 + n3;
            media = soma / i;
            Console.WriteLine("{0}, {1}, {2}, {3} => Soma = {4} Média = {5}", n1.ToString("0,0"), n2.ToString("0,0"),
                n3.ToString("0,0"),"9999",soma.ToString("0,0"), media.ToString("0,0"));


            /*  int i = 0, nrDig, soma = 0, media, s = 2;
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
            */
        }
    }
}

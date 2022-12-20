using System;

namespace TreinoForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPalavras, countPalavrasCS;
            string[] palavras, palavrasCS;

            //ENTRADA DE DADOS
            Console.WriteLine("Escreva numa mesma linha várias palavras, as separando com espaço.");
            Console.WriteLine("Assim, o progama irá dizer quantas palavras foram escritas, quantas começam com a letra C ou S e quais foram elas.");
            Console.WriteLine();

            palavras = Console.ReadLine().Split(' ');

            //PROCESSAMENTO DE DADOS
            totalPalavras = palavras.Length;
            palavrasCS = new string[totalPalavras];

            countPalavrasCS = 0;
            foreach (string palavra in palavras)
            {
                if (palavra[0] == 'C' || palavra[0] == 'c' || palavra[0] == 'S' || palavra[0] == 's') //considerando letras maiusculas e minusculas
                {
                    palavrasCS[countPalavrasCS] = palavra;
                    countPalavrasCS++;
                }
            }

            //SAÍDA DE DADOS
            Console.WriteLine();
            Console.WriteLine("Você escreveu um total de " + totalPalavras + " palavras");
            Console.WriteLine("Foram " + countPalavrasCS + " palavras que iniciam com C ou com S.");
            Console.WriteLine("Sendo elas:");

            foreach (string palavra in palavrasCS)
            {
                Console.WriteLine(palavra);
            }
        }

    }
}
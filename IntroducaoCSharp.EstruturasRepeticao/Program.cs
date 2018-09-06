using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCSharp.EstruturasRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "s";

            //Estrutura "while"
            while (resposta == "s" || resposta == "S")
            {
                string nome = Console.ReadLine();
                Console.WriteLine($"Olá, {nome}!");

                Console.WriteLine("Deseja continuar?");
                resposta = Console.ReadLine();
            }
            resposta = ""; // "Reseta" resposta para uma string vazia.

            //Estrutura "do...while"
            do
            {
                string nome = Console.ReadLine();
                Console.WriteLine($"Olá, {nome}!");

                Console.WriteLine("Deseja continuar?");
                resposta = Console.ReadLine();
            } while (resposta == "s");


            int[] numeros = { 1, 2, 3, 4, 5 };
            int soma = 0;
            
            //Estrutura "for"
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            Console.WriteLine(soma);
            soma = 0; //"Reseta" soma



            //Estrutura "foreach"
            foreach (int n in numeros)
            {
                soma += n;
            }
            Console.WriteLine(soma);

        }
    }
}

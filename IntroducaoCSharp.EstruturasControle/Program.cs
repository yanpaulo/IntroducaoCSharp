using System;

namespace IntroducaoCSharp.EstruturasControle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 10)
            {
                Console.WriteLine("Hello, World!");
                n++; // n = n + 1;
            }

        }

        private static void Senha()
        {
            string senha = "1234";
            string entrada = Console.ReadLine();

            if (entrada == senha)
            {
                Console.WriteLine("Senha CORRETA!!!");
            }
        }
    }
}

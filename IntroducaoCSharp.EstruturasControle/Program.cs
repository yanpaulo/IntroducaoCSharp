using System;

namespace IntroducaoCSharp.EstruturasControle
{
    class Program
    {
        static void Main()
        {
            string senha = "1234";
            string entrada = Console.ReadLine();

            if (entrada == senha)
            {
                Console.WriteLine("Senha CORRETA!!!");
            }
            else
            {
                Console.WriteLine("Senha INCORRETA");
            }
        }
    }
}

using System;

namespace IntroducaoCSharp.Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1.1: Invocação de método
            Console.WriteLine("Olá, mundo!");

            //Exemplo 1.2: Declaração de variáveis
            int m;
            int n, o;

            //Exemplo 1.3: Operações de atribuição
            m = 10;
            n = 20;
            o = 30;
            m = 10 + 1;
            n = m + 20;
            o = (m + n) * 30;

            //Exemplo 1.4: Declaração com atribuição
            int p = 10;
            int q = 20, r = 30;
            
            //Exemplo 1.5: Atribuição de retorno de método
            string a = Console.ReadLine();

            //Exemplo 1.6: Conversão de texto para número inteiro seguido de atribuição
            int x = int.Parse(a);

            //Exemplo 1.7: Expressão com a própria variável a ser atribuída
            x = x + 10;
            x += 10; //Atalho equivalente à expressão acima
            
            //Exemplo 1.8: Impressão de valor
            Console.WriteLine(x);

            //Exemplo 1.9: Interpolação de string
            Console.WriteLine($"O valor de x é {x}");


            //Exemplo 1.9: Exibir uma mensagem e aguardar o pressionamento de uma tecla.
            Console.WriteLine("Pressione alguma tecla para contiuar...");
            Console.ReadKey();
        }
    }
}

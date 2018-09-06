using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoCSharp.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo
            Hello();
            Hello();
            Hello();

            //Exemplo
            int resultado;
            resultado = 4;
            Console.WriteLine(resultado); //4 é impresso
                                          //No lugar do valor literal 4, poderia ser utilizado o método DoisMaisDois:
            resultado = DoisMaisDois();
            Console.WriteLine(resultado); //4 é impresso
                                          //O método pode ser chamado até mesmo dentro da instrução Console.WriteLine(), ao invés de se fornecer a variável “resultado”:
            Console.WriteLine(DoisMaisDois()); // 4 é impresso

            //Exemplo
            int dobroDe6 = Dobro(6);
            Console.WriteLine(dobroDe6); // Imprime 12
            int mediaDe6e8 = Media(6, 8);
            Console.WriteLine(mediaDe6e8); // Imprime 7

            var teste = Dobro(8);
        }

        static void Hello()
        {
            Console.WriteLine("Olá, mundo!");
        }
        
        static int DoisMaisDois()
        {
            int valor = 2 + 2;
            return valor;

        }

        static int Dobro(int valor)
        {
            return valor * 2;
        }

        static int Media(int valor1, int valor2)
        {
            return (valor1 + valor2) / 2;
        }

    }
}

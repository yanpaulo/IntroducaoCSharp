using System;
using IntroducaoCSharp.OO.OutroNamespace; //Cláusula using para abreviar o nome da classe em outro Namespace

namespace IntroducaoCSharp.OO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de inicialização das propriedades

            //Manual
            Pessoa p1 = new Pessoa();
            p1.Nome = "Yan"; //Atribuição de valor em Propriedade
            p1.Idade = 27;

            //Por construtor (requer que o construtor seja implementado na classe)
            Pessoa p2 = new Pessoa("Yen", 37);

            //Por inicializador (recurso da linguagem, não requer construtor)
            Pessoa p3 = new Pessoa { Nome = "Yin", Idade = 47 };

            //Em qualquer declaração com
            Pessoa p4 = new Pessoa { Nome = "Var", Idade = 99 };

            //Inicialização por construtor padrão
            Pessoa p5 = new Pessoa();

            //Objetos podem ser utilizados em coleções, tal qual variáveis
            var array = new Pessoa[]{ p1, p2, p3 };

            foreach (var p in array)
            {
                p.Falar();
                Console.WriteLine(p.Idade /* Leitura de valor de Propriedade */);
            }



            //Outros exemplos de declaração e inicialização

            //Uso de classe pelo nome completo
            //Classes em outro Namespace devem ser referenciadas pelo seu nome completo
            IntroducaoCSharp.OO.OutroNamespace.AlgumaClasse algumaInstancia = new IntroducaoCSharp.OO.OutroNamespace.AlgumaClasse();

            //O nome do Namespace pode ser omitido se houver uma cláusula using com o nome do Namespace:
            AlgumaClasse algumaOutraInstancia = new AlgumaClasse();

            //O nome de qualquer tipo ou classe pode ser substituído pela palavra "var". Isto é válido somente para declaração com atribuição.
            var aindaAlgumaOutraReferencia = new AlgumaClasse();
            var numero = 10;
            var texto = "Texo qualquer";
        }
    }
}


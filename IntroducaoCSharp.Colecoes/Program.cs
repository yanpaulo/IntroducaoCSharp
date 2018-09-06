using System;
using System.Collections.Generic;

namespace IntroducaoCSharp.Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //Array
            //Arrays são coleções de tamanho fixo de variáveis de um determinado tipo. Alguns utilizam o termo "vetor" para designar arrays.
            //A sintaxe para declaração de arrays é nome_do_tipo[] nome_da_array
            //Exemplo:
            int[] array; //Declara a array de inteiros

            //Somente declarar uma array não é o suficiente para utiliza-la.
            //É necessário inicializar a array.
            //Sintaxes possíveis:
            //  nome_da_array = new nome_to_tipo[tamanho]
            //  nome_da_array = new nome_do_tipo[] { elemento1, elemento2, elemento3 ..., elementon }
            //Exemplos de inicialização de array a seguir:

            array = new int[5]; //Inicialização com tamanho explícito (neste caso, os elementos recebem o valor padrão. Para o caso de int é 0.
            array = new int[] { 9, 6, 3, 8, 15 }; // Inicialização com tamanho inferido automaticamente

            //Operações:
            array[2] = 10; // Atribuição de valor: (no caso estamos atribuindo o valor 10 à posição de índice 2 (os índices iniciam do zero)
            int valorLido = array[0]; // Leitura de valor: (no caso estamos lendo o valor na posição de índice 0 e atribuindo à variável chamada 'valorLido'

            //Percorrendo array com ESTRUTURAS DE REPETIÇÃO

            //Estrutura "foreach"
            //Estrutura de sintaxe simples que serve para percorrer e executar operações em cada um dos elementos de uma array.
            //Na prática esta é a estrutura mais utilizada por desenvolvedores.
            //O exemplo a seguir imprime cada um dos elementos da array chamada 'lista'.
            foreach (int n in array) // A variável 'n' contem o elemento lido atualmente.
            {
                Console.WriteLine(n);
            }

            //Estrutura "for"
            //Apresenta uma sintaxe mais "carregada", porém mais flexível.
            //Permite percorrer somente trechos específicos da array.
            //A seguir temos o exemplo anterior, porém escrito utilizando o "for".
            for (int i = 0; i < array.Length; i++)//lista.Length representa o tamanho da lista, isto é, seu número de elementos.
            {
                int n = array[i];
                Console.WriteLine(n);
            }

            //Operações comunscom estruturas de repetição:

            //*Imprimir valores, como nos exemplos acima

            //*Alterar e fazer cálculos com base nos valores. Exemplos:

            //Multiplicando cada elemento por 2:
            for (int i = 0; i < array.Length; i++) //Utilizamos o "for" pois o "foreach" NÃO consegue alterar os valores da array. "foreach" consegue somente LER os mesmos.
            {
                int n = array[i]; //Lê elemento na posição i
                array[i] = n * 2; // Salva na posição i = valor lido 'n' multiplicado por 2.
            }

            //Obtendo a soma dos valores da array:
            int soma = 0;
            foreach (int n in array)
            {
                soma += n; //Equivalente a soma = soma + n;
            }

            //Calculando a média dos valores dos elementos da array:
            int media = soma / array.Length;
            #endregion

            #region Listas
            //Listas são coleções como as arrays, porém listas são mais flexíveis por terem um tamanho variável,
            //em oposição ao tamanho fixo das arrays.
            //Sintaxe para DECLARAÇÃO de uma lista:
            //List<nome_do_tipo> nome_da_lista;
            //Sintaxe para INICIALIZAÇÃO de uma lista:
            //  nome_da_lista = new List<nome_do_tipo>(); 
            //  nome_da_lista = new List<nome_do_tipo>();

            //Exemplo de declaração:
            List<int> lista;

            //Exemplos de inicialização:
            lista = new List<int>(); // Cria uma lista vazia
            lista = new List<int>() { 9, 6, 3, 8, 15 }; //Cria uma lista com elementos

            //Operações de Lista:
            lista.Insert(2, 15); //Insere o valor 15 depois da posição de íncide 2. A lista do exemplo se tornará { 9, 6, 15, 3, 8, 15 }
            lista.Add(9); //Adiciona o valor 9 no final da lista. A lista do exemplo se tornará { 9, 6, 15, 3, 8, 15, 9 }
            lista.RemoveAt(0); //Remove o elemento na posição de índice 0. A lista do exemplo se tornará { 6, 15, 3, 8, 15, 9 }
            lista.AddRange(array); //Adiciona todos os elementos  da coleção chamada "array" (no caso a array do exemplo anterior) ao final da lista.
                                   //A lista do exemplo se tornará { 6, 15, 3, 8, 15, 9, 9, 6, 3, 8, 15 }!!!!

            //Estruturas de repetição podem ser utilizadas em Listas tal qual são usadas em arrays, e com a mesma sintaxe:
            foreach (var n in lista)
            {
                Console.WriteLine(n);
            }
            #endregion
        }
    }
}

using System;

namespace IntroducaoCSharp.OO
{
    class Pessoa
    {
        //Propriedades
        public string Nome { get; set; } = "Goku";

        public int Idade { get; set; }

        #region Construtores
        //Construtor sem parâmetros
        public Pessoa()
        {

        }

        //Construtor com parâmetros
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        } 
        #endregion

        //Método
        public void Falar()
        {
            Console.WriteLine($"Oi, eu sou {Nome}!");
        }
    }
}


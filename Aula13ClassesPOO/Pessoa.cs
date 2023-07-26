using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13ClassesPOO
{
    internal class Pessoa
    {
        //Atributos (variaveis)
        public string nome;
        public int idade;
        public string rua;
        public string cidade;

        //Metodo construtor
        public Pessoa(string nome, int idade, string rua, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
            Console.WriteLine("\n\nSalve guys fui criado");
        }

        public void mostra()
        {
            Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos e moro na rua, {rua} na cidade de, {cidade}");
        }





    }

}

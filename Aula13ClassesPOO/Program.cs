using Aula13ClassesPOO;
using System.Security.Cryptography;

//Console.WriteLine("Hello, World!");

Pessoa Camila = new Pessoa("Camila", 19, "rua X", "são carlos");
Pessoa Kenedy = new Pessoa("Kenedy", 17, "rua X2", "são carlos");

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(Camila);
pessoas.Add(Kenedy);

for (int i = 0; i < pessoas.Count; i++)
{
    pessoas[i].mostra();
    //Console.WriteLine(pessoas[i].nome);
}

Console.ReadKey();
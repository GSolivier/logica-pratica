//Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
//cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
//Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
//exemplo, bubble sort) para ordenar os nomes.

List<string?> names = [];

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine($"Digite o {i + 1}º nome:");

    var name = Console.ReadLine();

    names.Add(name);
    
}

var ordenedNames = names.OrderBy( x => x).ToList();

Console.WriteLine("Os nomes cadastrados foram:");

ordenedNames.ForEach( name => {
    Console.WriteLine(name);
});
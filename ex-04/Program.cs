//Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
//número até o número 10. Utilize um laço for para gerar os múltiplos do número.


System.Console.WriteLine("Digite um número para gerar sua tabuada:");

var num = int.Parse(Console.ReadLine()!);


var list = generateMultiplicationTable(num);

foreach (var item in list)
{
    System.Console.WriteLine(item);
}

static List<string> generateMultiplicationTable(int num) {

    List<string> results = [];

    for (int i = 0; i <= 10; i++)
    {
        results.Add($"{num} x {i} = {num * i}");
    }


    return results;
}
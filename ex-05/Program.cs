//Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
//letra do alfabeto aparece no texto.

Console.WriteLine("Digite um texto qualquer:");
var text = Console.ReadLine();


if (string.IsNullOrEmpty(text))
{
    Console.WriteLine("Texto não pode ser vazio.");
    return;
}


text = new string(text.Where(c => Char.IsLetter(c)).ToArray()).ToLower();


var letterCount = new Dictionary<char, int>();


foreach (var letter in text)
{
    if (letterCount.TryGetValue(letter, out int value))
    {
        letterCount[letter] = ++value;
    }
    else
    {
        letterCount[letter] = 1;
    }
}


foreach (var kvp in letterCount.OrderBy(kvp => kvp.Key))
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
// número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

System.Console.WriteLine("Digite um número:");

int num;

bool tryInt = int.TryParse(Console.ReadLine() , out num);

do
{
    if (tryInt) {
        if (num % 2 == 0) {
             Console.WriteLine($"O número {num} é par!");
        }

        else {
             Console.WriteLine($"O número {num} é impar!");
        }
    } else {
        Console.WriteLine("Digite um número válido");
        tryInt = true;
    }
} while (tryInt == false);
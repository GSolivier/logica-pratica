//Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
//Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
//os números pares.

int[] numbers = [10, 20, 40, 55, 47, 56, 68, 49, 2, 7];

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sum += numbers[i];
    }
}

System.Console.WriteLine($"A soma dos numeros pares da lista é: {sum}");

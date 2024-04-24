// 3. faça um programa que sorteie 6 numeros da mega-sena e grave-os num vetor ordenado;

int tamanho = 6, aux = 0, verificacao = 0;
int[] sorteio = new int[tamanho];

for (int i = 0; i < tamanho; i++)
{
    verificacao = 0;
    aux = new Random().Next(1, 61);
    for (int j = tamanho - 1; j > -1; j--)
    {
        if (aux == sorteio[j])
            verificacao++;            
    }
    if (verificacao == 0)
        sorteio[i] = aux;
    else
        i--;
}

Console.WriteLine("\nSorteio sem ordenação:");
for (int i = 0; i < tamanho; i++)
    Console.Write($"{sorteio[i]}, ");
Console.WriteLine("\n");

for (int i = 0; i < tamanho - 1; i++)
{
    for (int j = i + 1; j < tamanho; j++)
    {
        if (sorteio[i] > sorteio[j])
        {
            aux = sorteio[i];
            sorteio[i] = sorteio[j];
            sorteio[j] = aux;
        }
    }
}

Console.WriteLine("\n\nsorteio com ordenação:");
for (int i = 0; i < tamanho; i++)
    Console.Write($"{sorteio[i]}, ");
Console.WriteLine("\n");
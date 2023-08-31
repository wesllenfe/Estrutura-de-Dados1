int[] numeros = new int[10];

Random random = new Random();
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = random.Next(1, 100);
}

Console.WriteLine("Vetor desordenado:");
ImprimirVetor(numeros);

Array.Sort(numeros);

Console.WriteLine("\nVetor ordenado:");
ImprimirVetor(numeros);

static void ImprimirVetor(int[] numeros)
{
    foreach (int valor in numeros)
    {
        Console.Write(valor + " ");
    }
    Console.WriteLine();
}
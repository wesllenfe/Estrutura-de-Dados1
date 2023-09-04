int[,] matriz = new int[3, 3];
int linha, coluna;

Console.WriteLine("Preencha a matriz com os valores 0 ou 1!");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        bool posicaoValida = false;
        do
        {
            Console.Write($"Informe o valor (0 ou 1) para a posição [{i},{j}]: ");
            if (int.TryParse(Console.ReadLine(), out int valor) && (valor == 0 || valor == 1))
            {
                matriz[i, j] = valor;
                posicaoValida = true;
            }
            else
            {
                Console.WriteLine("Valor inválido. Insira 0 ou 1.");
            }
        } while (!posicaoValida);
    }
}

Console.WriteLine("\nMatriz resultante:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
class Program
{
    static char[,] matriz = new char[3, 3];

    static void Main()
    {
        InicializarMatriz();
        ImprimirMatriz();

        bool jogoAcabou = false;
        char jogadorAtual = 'X';

        while (!jogoAcabou)
        {
            Console.WriteLine($"Turno do jogador {jogadorAtual}");
            Console.Write("Informe a linha (0, 1 ou 2): ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Informe a coluna (0, 1 ou 2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (MarcarPosicao(linha, coluna, jogadorAtual))
            {
                jogoAcabou = VerificarVitoria(jogadorAtual);
                if (!jogoAcabou)
                {
                    jogoAcabou = VerificarEmpate();
                    jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Posição inválida. Tente novamente.");
            }

            ImprimirMatriz();
        }

        if (jogoAcabou)
        {
            Console.WriteLine($"Jogador {jogadorAtual} venceu!");
        }
        else
        {
            Console.WriteLine("O jogo empatou!");
        }
    }

    static void InicializarMatriz()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = ' ';
            }
        }
    }

    static void ImprimirMatriz()
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  -----");
        }
    }

    static bool MarcarPosicao(int linha, int coluna, char jogador)
    {
        if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && matriz[linha, coluna] == ' ')
        {
            matriz[linha, coluna] = jogador;
            return true;
        }
        return false;
    }

    static bool VerificarVitoria(char jogador)
    {
        for (int i = 0; i < 3; i++)
        {
            if (matriz[i, 0] == jogador && matriz[i, 1] == jogador && matriz[i, 2] == jogador)
            {
                return true;
            }

            if (matriz[0, i] == jogador && matriz[1, i] == jogador && matriz[2, i] == jogador)
            {
                return true;
            }
        }

        if (matriz[0, 0] == jogador && matriz[1, 1] == jogador && matriz[2, 2] == jogador)
        {
            return true;
        }

        if (matriz[0, 2] == jogador && matriz[1, 1] == jogador && matriz[2, 0] == jogador)
        {
            return true;
        }

        return false;
    }

    static bool VerificarEmpate()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matriz[i, j] == ' ')
                {
                    return false;
                }
            }
        }

        return true;
    }
}
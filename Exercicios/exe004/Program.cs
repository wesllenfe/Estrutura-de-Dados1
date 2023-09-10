using System.Diagnostics;
using exe004;

Stack pilha = new Stack();

do
{
    Console.WriteLine("Informe o valor para a pilha:");
    int valor = Convert.ToInt32(Console.ReadLine());
    pilha.Push(valor);

    Console.WriteLine("Deseja informar um novo valor?");
    Console.WriteLine("1 - Sim");
    Console.WriteLine("2 - Não");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x != 1)
    {
        break;
    }

} while (true);

pilha.PrintStack();
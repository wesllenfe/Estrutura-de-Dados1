using System.Collections;

Hashtable cpfNome = new Hashtable();

while (true)
{
    Console.Write("Digite o CPF: ");
    string cpf = Console.ReadLine();

    Console.Write("Digite o Nome: ");
    string nome = Console.ReadLine();

    try
    {
        if (cpfNome.ContainsKey(cpf))
        {
            Console.WriteLine("CPF já inserido previamente.");
        }
        else
        {
            cpfNome.Add(cpf, nome);
            Console.WriteLine("CPF e Nome adicionados com sucesso.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao adicionar CPF e Nome: {ex.Message}");
    }

    Console.Write("Deseja continuar (S/N)? ");
    string continuar = Console.ReadLine();

    if (continuar.ToUpper() != "S")
    {
        break;
    }
}

Console.WriteLine("\nDados inseridos:");
foreach (DictionaryEntry de in cpfNome)
{
    Console.WriteLine($"CPF: {de.Key} - Nome: {de.Value}");
}
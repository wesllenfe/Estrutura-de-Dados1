using System.Collections;

//Criar Hashtable
Hashtable openWith = new Hashtable();

openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

try
{
    openWith.Add("txt", "notepad++.exe");
}

catch (ArgumentException aex)
{
    Console.WriteLine("você tentou adicionar uma chave que já existe ");
    Console.WriteLine($"Detalhes:{aex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("Erro Generico");
}

Console.WriteLine(" Na chave = \"rtf\"  é {0} ", openWith["rtf"]);
Console.WriteLine("Programa em Execução");

//Aterando o conteúdo da tabela Hash
openWith["rtd"] = "winWord.Exe";
Console.WriteLine(" Na chave = \"rtf\"  é {0} ", openWith["rtf"]);

// testando se a chave existe

if (!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada.");
}

// percorrendo hash com foreach

Console.WriteLine();
foreach( DictionaryEntry de in openWith )
{

    Console.WriteLine("Key = {0} - value = {1}", de.Key, de.Value);

}

// Obtendo apenas os valores do hash

ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}

// Obtendo apenas os chaves do hash

ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("key = {0}", s);
}

// Removendo registros do hash

Console.WriteLine("Removendo (\"doc\")");
openWith.Remove("doc");

if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Chave \"doc\" foi removida");
}

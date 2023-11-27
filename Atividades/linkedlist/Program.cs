using LinkedList;

Page pageFirst = new Page()
{
    Content = "Atualmente..."
};

Page pageSecond = new Page()
{
    Content = "Aplicação..."
};

Page pageThird = new Page()
{
    Content = "Muito de..."
};

Page pageFourth = new Page()
{
    Content = "Você sabia..."
};

Page pageFifth = new Page()
{
    Content = "Enquanto..",
    PageNumber = 5
};

Page pageSixth = new Page();
//{
//    Content = "Você poderia..."
//};
pageSixth.Content = "Você poderia...";
pageSixth.PageNumber = 6;

var pageSeventh = new Page();
pageSeventh.Content = "Era uma vez...";
pageSeventh.PageNumber = 7;

LinkedList<Page> pages = new LinkedList<Page>();
int quantidade = pages.Count;
pages.AddLast(pageSecond);
LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth);
//Procedimento executa uma ação mas não tem retorno
pages.AddLast(pageSixth);
pages.AddFirst(pageFirst);
pages.AddBefore(nodePageFourth, pageThird);
pages.AddAfter(nodePageFourth, pageFifth);

LinkedListNode<Page> current = pages.First;
int number = 1;

while (current != null)
{
    Console.Clear();
    string numberString = $"- {number} -";
    int leadingSpaces = (90 - numberString.Length) / 2;
    Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
    Console.WriteLine();

    string content = current.Value.Content;
    for (int i = 0; i < content.Length; i += 90)
    {
        string line = content.Substring(i);
        line = line.Length > 90 ? line.Substring(0, 90) : line;
        Console.WriteLine(line);
    }
    Console.WriteLine();
}

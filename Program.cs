Console.Clear();

Console.WriteLine(" --- Imitando Dory ---\n");
string frase = Console.ReadLine()!;
string dory = frase

        .Replace("A","AAA" )
        .Replace("a", "aaa")
        .Replace("E","EEE")
        .Replace("e","eee")
        .Replace("I","III")
        .Replace("i","iii")
        .Replace("O","OOO")
        .Replace("o","ooo")
        .Replace("U","UUU")
        .Replace("u","uuu");

Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("----- Falando em Baleies -----\n\n");

        Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine($"{dory}\n\n");
        Console.ResetColor();

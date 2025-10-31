using System;
class Program
{
    static void Main()
    {
        string poems = " тучки небесные, вечные странники...";
        char[] div = { ' ', ',', '.' };
        string[] parts = poems.Split(div, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Результат разбиения строки на части: ");
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine(parts[i]);
        }
    }
}
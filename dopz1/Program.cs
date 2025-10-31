using System;
class Program
{
    static void Main()
    {
        string poems = " тучки небесные, вечные странники...";
        char[] div = { ' ', ',', '.' };

        string[] parts = poems.Split(div, StringSplitOptions.RemoveEmptyEntries);
    }
}
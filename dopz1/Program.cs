using System;
class Program
{
    static void Main()
    {
        // Исходная строка с текстом стихотворения
        string poems = " тучки небесные, вечные странники...";
        // Массив символов-разделителей: пробел, запятая, точка
        char[] div = { ' ', ',', '.' };
        // Разделение строки на части по указанным разделителям, исключая пустые элементы
        string[] parts = poems.Split(div, StringSplitOptions.RemoveEmptyEntries);
        // Вывод результата разбиения строки
        Console.WriteLine("Результат разбиения строки на части: ");
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine(parts[i]); // Вывод каждого слова отдельно
        }
        // Инициализация строки для обратной сборки
        string whole = "";
        // Сборка слов в обратном порядке с разделителем " | "
        for (int i = parts.Length - 1; i >= 0; i--)
        {
            whole += parts[i];// Добавление слова
            // Добавление разделителя, кроме последнего слова
            if (i > 0) whole += " | ";
        }
        // Вывод результата обратной сборки
        Console.WriteLine("Результат сборки в обратном порядке: ");
        Console.WriteLine(whole);
    }
}
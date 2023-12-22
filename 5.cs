using System;

class work_1_4
{
    static void Main()
    {
        Console.Write("Введите строку: "); // ввод инфы
        string user = Console.ReadLine(); // данные пользователя

        int count = 1; // счётчик
        foreach (char sym in user) // в user
        { 
            if (sym == ' ') count++; // если находим пробел, но count+1
        } 
        
        Console.WriteLine($"Изменённая строка: Start {user} End"); // вывод
        Console.WriteLine($"Количество слов в строке: {count}"); // вывод
    }
}
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// 29.11.2022 Sergey Dorofeev

Console.Clear();

Console.WriteLine ("Задача 64: Вывод натуральных чисел в промежутке от N до 1 методом рекурсии");

// Создаем метод для ввода числа пользователем

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

// Создаем метод вывода чисел рекурсией

int NatNbrRev (int num)
{
    if (num == 1)
    {
        return 1;
    }
    else 
    {
        Console.Write ($"{num}, ");
        num = NatNbrRev (num-1);
    }
    return num;
}

int n = InputNum ("Введтите число N: ");
Console.WriteLine (NatNbrRev (n));

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// 29.11.2022 Sergey Dorofeev

Console.Clear();

Console.WriteLine ("Задача 66: Сумма натуральных чисел в промежутке от M до N методом рекурсии");

// Создаем метод для ввода числа пользователем

int InputNum (string message)
{
    Console.Write (message);
    return Convert.ToInt32 (Console.ReadLine ());
}

// Создаем метод нахождения суммы элементов

int SumNbr (int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else 
    {
        n += SumNbr (m, n-1);
    }
    return n;
}

int m = InputNum ("Введите число M: ");
int n = InputNum ("Введите число N: ");
Console.Write ($"Сумма чисел от {m} до {n} = {SumNbr (m, n)}");

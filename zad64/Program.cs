/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


void ShowNumbers (int num)
{
    Console.Write($"{num}, ");
    if (num > 2) ShowNumbers (num -1);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Lutsenko()
{
    Console.WriteLine("The author of the work - Lutsenko A.S.");
}




int digit = ReadInt("Write your number N ");
ShowNumbers(digit);
Console.WriteLine(1);
Lutsenko();
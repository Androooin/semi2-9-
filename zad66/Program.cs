/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sumdig(int num1, int num2)
{
    if (num2 < num1)return sumdig(num1 - 1, num2) + num1;
    if (num2 > num1)return sumdig(num1,num2 - 1) + num2;
    else return num1;
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



int digitM = ReadInt("Write your digit M ");
int digitN = ReadInt("Write your digit N ");
Console.WriteLine($"sum = {sumdig(digitM, digitN)}");
Lutsenko();

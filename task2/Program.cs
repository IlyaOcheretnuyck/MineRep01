﻿//
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. (Сравнить с каждым)

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//

int max = 0;

Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

if(numberA > max)
{
    max = numberA;
}
if(numberB > max)
{
    max = numberB;
}
if(numberC > max)
{
    max = numberC;
}

Console.WriteLine("max = " + max);


﻿/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
PrintNumbers(n,m);

void PrintNumbers(int N,int a){
    if(a <= N){
        Console.WriteLine(a);
        a++;
        PrintNumbers(N,a);
    }
}


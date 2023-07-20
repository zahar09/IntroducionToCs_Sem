
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;
GetSumOfNumbers(n);

Console.WriteLine(sum);



void GetSumOfNumbers(int number){
    if(number != 0){
        sum += number % 10;
        GetSumOfNumbers(number/10);
    }
}
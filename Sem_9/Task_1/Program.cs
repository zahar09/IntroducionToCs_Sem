/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int number = 1;
Console.WriteLine();
PrintNumbers(n,number);

void PrintNumbers(int N,int a){
    if(a <= N){
        Console.WriteLine(a);
        a++;
        PrintNumbers(N,a);
    }
}

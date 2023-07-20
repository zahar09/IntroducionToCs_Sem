// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
int ans = 1;
GetAns(n,m);
Console.WriteLine(ans);

void GetAns(int number1,int number2){
    if(number2 > 0){
        //Console.WriteLine(number1);
        ans *= number1;
        number2--;
        GetAns(number1,number2);
    }

}
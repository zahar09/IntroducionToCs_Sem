// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 1;
Console.Write($"{num} ->  ");
while(i <= num){
    
    if(i == num){
        Console.Write($"{i * i}");
    }
    else{
        Console.Write($"{i * i}, ");
    }
    i++;
}
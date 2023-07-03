//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Write("Введите число N : ");
int num = int.Parse(Console.ReadLine());
Console.Write($"{num} -> {Mult(num)} == ");
MultPrint(num);

int Mult(int number){
    int _mult = 1;
    for(int i = 1;i <= number;i++){
        _mult *= i;
    }
    return _mult;
}

void MultPrint(int number){
    for(int i = 1;i <= number;i++){
        if(i == number){
            Console.Write(i);
        }
        else{
            Console.Write($"{i} * ");
        }
    }
}





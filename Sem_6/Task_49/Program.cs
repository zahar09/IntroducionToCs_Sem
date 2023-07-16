/***Задача 49:** Задайте двумерный массив. Найдите элементы,
 у которых оба индекса не чётные, и замените эти элементы на их квадраты.

Например, изначально массив выглядел вот так:

1 4 7 2

5 9 2 3

8 4 2 4

Новый массив будет выглядеть вот так:

1 4 7 2

5 **81** 2 **9**

8 4 2 4*/
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное число в массиве: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное число в массиве: ");
int min = int.Parse(Console.ReadLine());

int[,] array = GetArray(m,n,min,max);
PrintArray(array);

ChangeArray(array);

Console.WriteLine();
PrintArray(array);


int[,] GetArray(int m,int n,int min,int max){
    int[,] array = new int[m,n];

    for(int i = 0;i < m;i++){
        for(int j = 0;j < n;j++){
            array[i,j] = new Random().Next(min,max + 1);
        }
    }
    return array;
}


void ChangeArray(int[,] array){
    for(int i = 0;i < array.GetLength(0);i++){
        for(int j = 0;j < array.GetLength(1);j++){
            if(i % 2 != 0 && j % 2 != 0){
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
}

void PrintArray(int[,] arr){
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0;j < arr.GetLength(1);j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}


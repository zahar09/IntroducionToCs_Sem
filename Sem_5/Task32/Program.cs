/* **Задача 32:**Напишите программу замена элементов маccива: 
положительные элементы замените на моответѝтвующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]  String.Join(", ", array)*/
Console.Clear();
PrintAns(CreatArr());

int[] CreatArr(){
    int n = new Random().Next(2, 10);
    int[] arr = new int[n];
    for(int i = 0;i < arr.Length;i++){
        arr[i] = new Random().Next(-10, 10);
    }
    return arr;
}

void PrintAns(int[] array){
    Console.Write("[");
    for(int i = 0;i < array.Length - 1;i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1] }] -> [");
    
    for(int i = 0;i < array.Length - 1;i++){
        Console.Write($"{-array[i]}, ");
    }
    Console.Write($"{-array[array.Length - 1] }]");
}


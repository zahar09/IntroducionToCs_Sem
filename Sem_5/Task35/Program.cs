/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/
Console.Clear();
int[] arrey = CreatArr();
FindNumbersInArr(arrey);
int[] CreatArr(){
    int[] arr = new int[123];
    for(int i = 0;i < arr.Length;i++){
        arr[i] = new Random().Next(0,123);
    }
    return arr;
}

void FindNumbersInArr(int[] arr){
    Console.Write("[");
    int e = 0;
    for(int i = 0;i < arr.Length - 1;i++){
        Console.Write($"{arr[i]}, ");
        if(arr[i] >= 10 && arr[i] <= 99){
            e++;
        }
    }

    if(arr[arr.Length - 1] >= 10 && arr[arr.Length - 1] <= 99){
        e++;
    }
    Console.Write($"{arr[arr.Length - 1]}] -> {e}");
}
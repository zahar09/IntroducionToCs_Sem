//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//int[]
// //[1,0,1,1,0,1,0,0]
// int a = new Random().Next(2, 7);
// int b = new Random().Next(2);
PrintArr(Arr());

int[] Arr(){
    int n = 8;
    int[] arr = new int[n];
    for(int i = 0;i < arr.Length;i++){
        arr[i] = new Random().Next(2);
    }
    return arr;
}
void PrintArr(int[] arr){
    Console.Write("[");
    for(int i = 0;i < arr.Length - 1;i++){
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}
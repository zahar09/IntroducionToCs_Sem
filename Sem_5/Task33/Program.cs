/* **Задача 33:**Задайте массив.Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет
3; массив[6, 7, 19, 345, 3]->да*/
Console.Clear();

Console.Write("Введите массив через пробел: ");
string s = Console.ReadLine();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] arr = CreatArr(s);
FindNum(arr, num);

int[] CreatArr(string string_arr){
    string[] arr = string_arr.Split(" ");
    int[] numbers = new int[arr.Length];
    for(int i = 0;i < numbers.Length;i++){
        numbers[i] = int.Parse(arr[i]);
    }
    return numbers;
}

void FindNum(int[] arr, int number){
    for(int i = 0;i < arr.Length;i++){
        if(arr[i] == number){
            Console.Write("да");
            break;
            
        }
        if(i == arr.Length - 1){
            Console.Write("нет");
        }
    }
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {Numbers(num)}");

int Numbers(int number){
    int count = 0;
    if(number == 0){
        count = 1;
    }
    else{

        while(number > 0){
            number /= 10;
            count++;
        }
    }

    return count;
}



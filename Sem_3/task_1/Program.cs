﻿// See https://aka.ms/new-console-template for more information
Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

if(num == 1){
    Console.WriteLine("x > 0, y > 0");
}
else if(num == 2){
    Console.WriteLine("x < 0, y > 0");
}
else if(num == 3){
    Console.WriteLine("x < 0, y < 0");
}
else if(num == 4){  
    Console.WriteLine("x > 0, y < 0");

}
else{
    Console.WriteLine("Такой четверти не сушествует");
}
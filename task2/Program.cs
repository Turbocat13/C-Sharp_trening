// Напишите программу, которая будет на вход принимать два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит отстаток от деления

Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine($"не кратно, остаток {n % m}");
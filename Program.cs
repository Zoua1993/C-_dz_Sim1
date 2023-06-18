// Задача 1.
// Написать программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("большее число "  +a+ " меньшее число " + b);
}
else 
{
    Console.WriteLine("большее число "  +b+ " меньшее число " + a);
} 


// Задача 2.
// Напишите задачу, которая принимает на вход 3 числа и выдает максимально из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.WriteLine("Mаксимальное из этих чисел");
Console.WriteLine(max);


// Задача 3.
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Число " +a+ " Четное");
}
else
{
    Console.WriteLine("Число: " +a+" нечетное");
}


// Задача 4.
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
}



/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите число => ");
int number = Convert.ToInt32(Console.ReadLine());
int n2 = number % 100 / 10;
Console.Write($"Вторая цифра {number} = ");
Console.Write(n2);
////////////    Можно и так.
/*
int number = new Random().Next(100, 1000);
Console.WriteLine($"Данно число {number}");
int n2 = number % 100 / 10;
Console.Write($"Вторая цифра {number} = ");
Console.Write(n2);
*/
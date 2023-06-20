/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
//////////////

int number = new Random().Next(10, 200);
Console.WriteLine($"Наше случайное число => {number}");

    if (number / 100 == 0)
    {
        Console.WriteLine($"Число {number} двухзначное => третьей цифры нет");
    }
    else
    {
        int thirdNum = number % 10;
        Console.WriteLine($"Третья цифра числа {number} => {thirdNum}");
    }
    

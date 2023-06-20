/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
///////////////

Console.Write($"Enter the number => ");
int n = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>()
{
    {1, "Monday"},
    {2, "Tuesday"},
    {3, "Wednesday"},
    {4, "Thursday"},
    {5, "Friday"},
    {6, "Saturday"},
    {7, "Sunday"}
};
if (n > 0 & n < 6)
{
    Console.WriteLine($"{map[n]} - рабочий день");
    
}
else if (n == 6 | n == 7)
{
    Console.WriteLine($"{map[n]} - выходной день");
}
else
{
    Console.WriteLine($"Ошибка - неверно введены данные.");
}

//////////////// с командой "switch" у меня пока только так получилось
/*
Console.Write($"Enter the number => ");
int n = Convert.ToInt32(Console.ReadLine());
Dictionary<int, string> map = new Dictionary<int, string>()
{
    {1, "Monday"},
    {2, "Tuesday"},
    {3, "Wednesday"},
    {4, "Thursday"},
    {5, "Friday"},
    {6, "Saturday"},
    {7, "Sunday"}
};
switch (n)
{
    case 1: Console.WriteLine($"{map[n]} рабочий день");
        break;
    case 2: Console.WriteLine($"{map[n]} рабочий день");
        break;
    case 3: Console.WriteLine($"{map[n]} рабочий день");
        break;
    case 4: Console.WriteLine($"{map[n]} рабочий день");
        break;
    case 5: Console.WriteLine($"{map[n]} рабочий день");
        break;
    case 6: Console.WriteLine($"{map[n]} выходной день");
        break;
    case 7: Console.WriteLine($"{map[n]} выходной день");
        break;
    
}   
*/
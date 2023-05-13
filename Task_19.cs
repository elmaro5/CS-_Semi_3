//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");

string str = Console.ReadLine();

if (str.Length == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

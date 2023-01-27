// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число :");

int num = Convert.ToInt32(Console.ReadLine());
int numRevers = num % 10 * 10000 + num % 100 / 10 * 1000 + num % 1000 / 100 * 100 + num % 10000 / 1000 * 10 + num % 100000 / 10000;

if  (num == numRevers)
{
    System.Console.WriteLine($"{num} -> Да");
}
else
{
    System.Console.WriteLine($"{num} -> Нет");
}


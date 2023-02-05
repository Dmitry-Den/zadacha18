// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите пятизначное число а: ");
int a = int.Parse(Console.ReadLine()!);
int num1, num2, num4, num5 = 0;
while (a >= 10000 && a < 100000)
{
    num1 = (Math.Abs(a / 10000));
    num2 = (Math.Abs((a / 1000) %10));
    num4 = (Math.Abs((a % 100)/10));
    num5 = (Math.Abs(a % 10));
    if (num1 == num5 && num2 == num4)
        {
            Console.Write("Число а - полиндром");
        }
        else Console.Write("Число а - НЕ полиндром");
break;
}
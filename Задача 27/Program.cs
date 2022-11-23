//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.Write("Введите любое целое число: ");
var strNum = Console.ReadLine();
var num = Convert.ToInt32(strNum);
Console.WriteLine($"Сумма всех цифр данного числа равна {GetSum(strNum.Length, num)}");

static int GetSum(int leng, int num)
{
    var sum = 0;
    for (int i = 0; i < leng; i++)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}
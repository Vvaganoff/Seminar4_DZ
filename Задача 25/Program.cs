// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите основание степени: ");
var baseOf = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую нужно возвести: ");
var degreeOf = Convert.ToInt32(Console.ReadLine());

if (degreeOf <= 0)
{
    Console.WriteLine("Степень не натуральная и вданной задаче не рассматривается");
    return;
}

Console.WriteLine($"{degreeOf}-ая степень числа {baseOf} равняется: {BaseToDegree(baseOf, degreeOf)}");

static int BaseToDegree(int Base, int degree )
{
    return Convert.ToInt32(Math.Pow(Base, degree));
}
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33-> [6, 1, 33]

PrintRandomMassive();

static void PrintRandomMassive()
{
    int[] massive = new int[8];
    Random rndm = new Random();
    Console.Write("[");
    foreach (int i in massive)
    {
        massive[i] = rndm.Next(0, 100);
        Console.Write($"{massive[i]}. ");
    }
    Console.WriteLine("]");
}

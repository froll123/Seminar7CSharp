/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int colum = Convert.ToInt32(Console.ReadLine());

double[,] num = new double[rows, colum];

Seminar7CArray(num);
PrintArray(num);

void Seminar7CArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Write("Введите строку: ");
int rows1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int colum1 = Convert.ToInt32(Console.ReadLine()) - 1;
int n = 5; 
int m = 7;
int[,] arr = new int[n, m];

Console.WriteLine("Исходный массив: ");

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = new Random().Next(1,10);
    Console.Write("{0} ", arr[i, j]);
}

Console.WriteLine();
}
    if (rows1 < 0 | rows1 > arr.GetLength(0) - 1 | colum1 < 0 | colum1 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует: ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[rows1, colum1]);
}
Console.ReadLine();


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


    Console.Write("Введите строку: ");
    int rows2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец: ");
    int colum2 = Convert.ToInt32(Console.ReadLine());

    int[,] arr2 = new int[rows2, colum2];
    for (int i = 0; i < rows2; i++)
    {
        for (int j = 0; j < colum2; j++)
        {
            arr2[i,j] = new Random().Next(1,10);
            Console.Write(arr2[i,j] + " ");
        }
        Console.WriteLine(" ");
    }

        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            double sum = 0;
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                sum += arr2[i,j];
            }
            Console.Write($" {sum/arr2.GetLength(0)}");
        }
        Console.Write("");
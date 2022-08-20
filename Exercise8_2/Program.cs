/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows,columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return newArray;
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine();
    }
}


int MinSum(int [,] array)
{
    int[] newArray = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum+= array[i , j];
        }
        newArray[i]=sum;
    }
    int minimum = 0;
    
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        if(newArray[i] < newArray[minimum]) minimum = i;
    }
    return minimum;

}

int[,] array = CreateRandom2dArray(6, 4, 1, 10);
Show2dArray(array);
int minim = MinSum(array);
Console.WriteLine($"Номер строки сумма элементов которой наименьшая: {minim + 1}");



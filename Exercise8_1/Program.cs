/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8 */

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

int[,] SortirovkaMaxMin(int [,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = j;
            for( int n = j+1; n < array.GetLength(1); n++)
            {
                if(array[i , n] > array[i , max]) max = n;
            }
            int temp = array[i , j];
            array[i , j] = array[i , max];
            array[i , max] = temp;
        }
    }
    return array;
}

int[,] array = CreateRandom2dArray(4, 4, 1, 10);
Show2dArray(array);
Console.WriteLine("");
int[,] sortirovka = SortirovkaMaxMin(array);
Show2dArray(sortirovka);
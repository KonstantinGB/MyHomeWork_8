 /*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */

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

int[,] Proizvedenie (int [,] arrayOne, int [,] arrayTwo)
{
    int[,] newArray = new int[arrayOne.GetLength(0) ,arrayOne.GetLength(1)];

    for(int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for(int j = 0; j < arrayOne.GetLength(1); j++)
        {
            newArray[i , j] = arrayOne[i , j] * arrayTwo [i , j];
        }
    }
    return newArray;
}

int[,] arrayOne = CreateRandom2dArray(6, 4, 1, 10);
Show2dArray(arrayOne);
Console.WriteLine("");
int[,] arrayTwo = CreateRandom2dArray(6, 4, 1, 10);
Show2dArray(arrayTwo);
Console.WriteLine("");
int[,] proizveenye = Proizvedenie(arrayOne, arrayTwo);
Show2dArray(proizveenye);



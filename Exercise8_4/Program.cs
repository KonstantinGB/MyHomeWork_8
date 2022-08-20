/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1) */


int[,,] CreateRandom3dArray(int rows, int columns, int trexmerniy)
{
    int[,,] newArray = new int[rows, columns, trexmerniy];
    int numbs = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
           for(int b = 0; b < trexmerniy; b++, numbs++)
           {
            newArray[i, j, b] = 10 + numbs;
           }        
           
        }
    }
    return newArray;
}

void Show3dArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for( int b = 0; b < array.GetLength(2); b++)
        {
            Console.Write($"{array[i,j,b]} ({i},{j},{b})  ");
        } 
        Console.WriteLine("");
    }
}
}

int[,,] arrayOne = CreateRandom3dArray(2, 2, 2);
Show3dArray(arrayOne); 


/* Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7 */
int[,] Spiralniy(int strok, int stolb)
{
 
 int[,] array = new int[strok, stolb];
 
 for(int startNumber = 0, krug = 0, row = strok - 1, col = stolb - 1; startNumber < strok * stolb; krug++, row--, col--)
    {
 for(int j = krug; j <= col; j++, startNumber++)
  array[krug, j] = startNumber;
 for(int i = krug + 1; i <= row; i++, startNumber++)
  array[i, col] = startNumber;
 for(int j = col - 1; j >= krug; j--, startNumber++)
  array[row, j] = startNumber; 
 for(int i = row - 1; i >= krug + 1; i--, startNumber++) 
 array[i, krug] = startNumber;        
    }
 return array;

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

Console.Write("Введите количество строк в массиве: ");
int strok = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] array = Spiralniy(strok, stolb);
Show2dArray(array);
/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GenerateArray2DDbl (int rows, int cols, int min, int max)
{
    double[,] array = new double[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            array[i, j] += new Random().NextDouble(); 
        }
    return array;
}

void PrintArray2DDbl (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + Math.Round(array[i, j], 1) + "\t");
        Console.Write("\n");
    }
}

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimal integer value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal integer value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = GenerateArray2DDbl(rows, cols, min, max);
PrintArray2DDbl(myArray);
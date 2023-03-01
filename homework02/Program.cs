/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/

int[,] GenerateArray2DInt (int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray2DInt (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + " ");
        Console.Write();
    }
}

int GetArrayElement(int row, int col, int[,] array)
{
    return array[row, col];
}

Console.Write("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = GenerateArray2DInt(rows, cols, min, max);
PrintArray2DInt(myArray);
Console.Write("Enter number of the row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of the column: ");
int col = Convert.ToInt32(Console.ReadLine());
if(row < 0 || col < 0 || row >= rows || col >= cols)
    Console.WriteLine($"Entered element [{row}, {col}] does not exist!");
else
{
    int element = GetArrayElement(row, col, myArray);
    Console.WriteLine($"Element [{row}, {col}] = {element}");
}

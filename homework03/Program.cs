int[,] GenerateArray2DInt (int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

double GetRowAverage(int[,] array, int columnIndex)
{
    double result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        result += array[i, columnIndex];
    return result / array.GetLength(0);
}

void PrintArray2DInt (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write((array[i, j] < 0 ? "": " ") + array[i, j] + " ");
        Console.WriteLine();
    }
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
Console.Write("Average of each column is: ");
for(int i = 0; i < cols; i++)
    Console.Write(GetRowAverage(myArray, i) + "; ");
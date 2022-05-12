Console.Clear();

Console.WriteLine("Введи высоту массива:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введи ширину массива:");
int n = int.Parse(Console.ReadLine());

int[,] numbers = GetArray(m, n);
PrintArray(numbers);


int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
        }

    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }

}
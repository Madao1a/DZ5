// Написать программу копирования массива
int [,] CreateMatrix(int length, int widht)
{
    Random rand = new Random();
    int[,] matrix = new int[length, widht];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(-10,10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write ($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

/*int [,] CopyMatrix(int length, int widht, int[,] matrix)
{
    int[,] matrix2 = new int[length, widht];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = matrix[i,j];
        }
    }
    return matrix2;
}*/


int ReadInt (string massage)
{
    Console.WriteLine (massage);
    return int.Parse(Console.ReadLine()!);
}

int length = ReadInt("Enter amount legth ");
int widht = ReadInt("Enter amount widht  ");


int[,] matrix = CreateMatrix(length, widht);
PrintMatrix(matrix);

//int[,] matrix2 = CopyMatrix(length, widht);

    int[,] matrix2 = new int[length, widht];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i,j] = matrix[i,j];
        }
    }
PrintMatrix(matrix2);
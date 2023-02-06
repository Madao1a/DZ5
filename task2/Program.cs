// Написать программу масштабирования фигуры
// Написать программу масштабирования фигуры
int [,] CreateMatrix(int length)
{
    Random rand = new Random();
    int[,] matrix = new int[length, 2];
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

/*int[,] UpdateMatrix (int[,] matrix, int K)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matrix[i,j]*K;
        }
    }
    return matrix;
}*/

int ReadInt (string massage)
{
    Console.WriteLine (massage);
    return int.Parse(Console.ReadLine()!);
}

int length = ReadInt("Введите количество вершин фигуры  ");
//int widht = ReadInt("Enter amount widht  ");
int K = ReadInt(" Enter amount K=  ");

int[,] matrix = CreateMatrix(length);
PrintMatrix(matrix);
//UpdateMatrix(matrix);



    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = matrix[i,j]*K;
        }
    }


PrintMatrix(matrix);
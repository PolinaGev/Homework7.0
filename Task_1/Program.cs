int rows = 3;
int columns = 4;

double[,] GetArray(int m, int n)
{
    var result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j]  = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(Double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         System.Console.WriteLine($"{arr [i,j]} ");  
        }
    }
    System.Console.WriteLine();
}
PrintArray(GetArray(rows, columns));
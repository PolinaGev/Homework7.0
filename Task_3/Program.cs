int rows = 3;
int columns = 4;

int[,] Array(int m, int n)
{
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           result[i,j]  = new Random().Next(99);
        }
    }
    return result;
}

double[] Average(int [,] arr)
{
    var result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        result[i] = sum/ arr.GetLength(0);
    }
    return result;
}

foreach (var item in Average(Array(rows,columns)))
{
    System.Console.WriteLine(item);
}
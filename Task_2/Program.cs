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

bool Contains( int [,] arr, int elements)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         if(arr[i,j] == elements)
         return true;
        }
    }
    return false;
}

var arr = Array(rows, columns);
System.Console.WriteLine(Contains(arr, 54));
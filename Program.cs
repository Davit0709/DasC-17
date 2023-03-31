Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());


int[,] array = new int[m, n];


Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(100);
    }
}


Console.WriteLine("Исходный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = i; k < m; k++)
        {
            int l = j;
            if (k == i)
            {
                l++;
            }
            while (l < n)
            {
                if (array[i, j] > array[k, l])
                {
                    int temp = array[i, j];
                    array[i, j] = array[k, l];
                    array[k, l] = temp;
                }
                l++;
            }
        }
    }
}


Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

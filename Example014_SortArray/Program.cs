int[] CreateRandomArray(int length)
{

    int[] col = new int[length];
    int index = 0;
    while (index < length)
    {
        col[index] = new Random().Next(1, 10);
        index++;

    }
    return col;
}

void PrintArray(int[] col)
{

    int count = col.Length;

    for (int position = 0; position < count; position++)
    {

        Console.Write($"{col[position]} ");

    }
}

int[] SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
    return array;
}

int[] SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
    return array;
}

int[] array = CreateRandomArray(10);
PrintArray(array);
Console.WriteLine();
int[] arraymin = SelectionSortMin(array);
PrintArray(arraymin);
Console.WriteLine();
int[] arraymax = SelectionSortMax(array);
PrintArray(arraymax);

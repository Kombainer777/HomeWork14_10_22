// Подсчёт количества нечётных элементов в массиве
void FillArray(int [] arr, int min, int max)    //метод заполнения массива
    {
        for (int i=0; i<arr.Length; i++)
            arr[i] = new Random().Next(min, max);
    }


void PrintArray(int[] arr)                     // метод вывода массива на экран
{
    for (int i=0; i<arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int UnevenCount(int [] arr)                   // метод подсчета количества нечетных элементов в массиве
{
    int count=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2!=0)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, 1, 20);
PrintArray(arr);
int x = UnevenCount(arr);
Console.WriteLine($"Количество нечетных элементов в массиве равно: {x} ");
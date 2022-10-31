// Подсчёт количества положительных элементов в массиве
void FillArray(int[] arr, int min, int max)    //метод заполнения массива
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min, max);
}


void PrintArray(int[] arr)                     // метод вывода массива на экран
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
int NegativeCount(int[] arr)                   // метод подсчета количества положительных элементов в массиве
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[size];
FillArray(arr, -20, 20);
PrintArray(arr);
int x = NegativeCount(arr);
Console.WriteLine($"Количество положительных элементов в массиве равно: {x} ");


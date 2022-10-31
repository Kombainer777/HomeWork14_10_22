// Подсчёт количества отрицательных элементов массива
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
int NegativeCount(int [] arr)                   // метод подсчета количества отрицательных элементов в массиве
{
    int count=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]<0)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, -10, 10);
PrintArray(arr);
int x = NegativeCount(arr);
Console.WriteLine($"Количество отрицательных элементов в массиве равно: {x} ");

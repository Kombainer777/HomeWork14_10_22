// Подсчёт количества чётных элементов в массив
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
int EvenCount(int [] arr)                   // метод подсчета количества четных элементов в массиве
{
    int count=0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2==0)
        count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, 1, 20);
PrintArray(arr);
int x = EvenCount(arr);
Console.WriteLine($"Количество четных элементов в массиве равно: {x} ");

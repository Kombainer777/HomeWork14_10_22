// Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
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
bool CheckSort(int [] arr)                   // метод подсчета количества нечетных элементов в массиве
{
    bool a = true;
    for (int i=1; i<arr.Length; i++)
    {
        if (arr[i]<arr[i-1])
        a = false;      
    }
    return a;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];
FillArray(arr, 1, 20);
PrintArray(arr);
bool x = CheckSort(arr);
Console.WriteLine($"{x}");


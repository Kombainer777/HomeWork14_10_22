// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
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
Console.WriteLine("Введите количество элементов массива:");

int NumFind(int[] arr, int n)                   // метод поиска позиции числа в массиве
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == n)
            return i;

    return -1;
}
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[size];
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

FillArray(arr, 1, 5);
PrintArray(arr);
int x = NumFind(arr, n);
if (x == -1)
    Console.WriteLine($"Искомый элемент не найден; {x} ");
else
{
    Console.Write($"Искомый элемент находится на позиции(ях): {x + 1} ");
}
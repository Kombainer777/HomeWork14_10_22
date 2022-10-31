// Поиск суммы элементов массива. Метод
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

int Summ(int [] arr)                            // метод поиска суммы элементов массива
{
    int sum = 0;
    for (int i=0; i<arr.Length; i++)
        sum = sum + arr[i];
    return sum;
}
Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];


FillArray(arr, 0, 10);
PrintArray(arr);
int x = Summ(arr);
Console.WriteLine($"Сумма всех элементов массива равна: {x}");

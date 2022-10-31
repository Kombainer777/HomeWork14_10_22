// Поиск произведения элементов массива
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

int Multy(int [] arr)                            // метод поиска произведения элементов массива
{
    int s = 1;
    for (int i=0; i<arr.Length; i++)
        s = s * arr[i];
    return s;
}
Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int [] arr = new int [size];


FillArray(arr, 1, 5);
PrintArray(arr);
int x = Multy(arr);
Console.WriteLine($"Произведение всех элементов массива равна: {x}");

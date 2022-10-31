// Функцию, складывающую два целых числа
int Sum(int a, int b)
{
    int sum = 0;            // Т.к мы объявляем тип переменных a и b через int, то по умолчанию они являются целыми числами
    sum = a + b;
return sum;
 }

Console.WriteLine("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
int x = Sum(a, b);
Console.WriteLine($"Сумма чисел {a} и {b} равна: {x}" );

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите количество чисел, которы вы хотели бы ввести: ");
int size = int.Parse(Console.ReadLine());

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
}

void CalculationPositive(int[] array)
{
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write($"Количество чисел которое больше нуля равно - {count}");
}

int[] array = FillArray(size);
PrintArray(array);
CalculationPositive(array);

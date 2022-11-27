// Задача.
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] FillArraySrt(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] LimitedSizeArray(string[] array1)
{
    string[] arr2 = new string[array1.Length];
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] array1 = FillArraySrt(size);
PrintArray(array1);


// SecondArrayWithIF(array1, array2);
// PrintArray(arr);
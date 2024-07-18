void PrintArr(string[] arr)
{
    foreach (var e in arr);
    {
        System.Console.Write($"{e}, ");
    }
    System.Console.WriteLine();
}


string[] ArrayElements(int b)
{
    string[] arr = new string[b];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"{i + 1} элемент массива: ");
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}



Console.WriteLine("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

string[] arr = ArrayElements(a);

Console.WriteLine(arr);

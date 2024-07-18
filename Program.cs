void PrintArr(string[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
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


int b = 0;
foreach (var item in arr)
{
    if (item.Length <= 3)
    {
        b = b + 1;
    }
        
}

string[] FinalArray = new string[b];
int j = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
    {
        FinalArray[j] = arr[i];
        j++;
    }
}

PrintArr(FinalArray);
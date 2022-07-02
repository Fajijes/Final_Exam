// Написать программу, которая из имеюшегося
// массива строк формирует массив из строк,
// длина которых <=3 символа.

void MethodCreateInputArray(string[] InputArray)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < InputArray.Length; i++) Console.Write($"{InputArray[i]} ");
    Console.WriteLine();
}

void MethodCreateOutputArray(string[] OutputArray)
{
    Console.Write($"Output array: ");
    string[] newarr = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)
    {
        if (OutputArray[i].Length <= 3)
        {
            newarr[i] = OutputArray[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "hello_world", "2", "L0L", ":-)" , "123", "^_^", "wiz"};

Console.WriteLine();
MethodCreateInputArray(array);
Console.WriteLine();
MethodCreateOutputArray(array);
Console.WriteLine();

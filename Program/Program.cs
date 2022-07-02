// Написать программу, которая из имеюшегося
// массива строк формирует массив из строк,
// длина которых <=3 символа.

void MethodCreateOriginArray(string[] array)
{
    Console.Write($"Origin array: ");
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void MethodCreateNewArray(string[] array)
{
    Console.Write($"New array: ");
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "hello_world", "2", "L0L", ":-)" , "123", "^_^", "wiz"};

MethodCreateOriginArray(array);
MethodCreateNewArray(array);


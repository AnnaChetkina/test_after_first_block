void PrintShortArray(string[] array)
{
     Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] -> ");

    array = array.Where(item => item.Length <= 3).ToArray();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] array1 = {"hello", "2", "world", ":)"}; 
string[] array2 = {"1234", "1567", "-2", "computer science"}; 
string[] array3 = {"Russia", "Denmark", "Kazan"};

PrintShortArray(array1); //  [2, :)]
PrintShortArray(array2); // [-2]
PrintShortArray(array3);  // []

string[] array1 = new string[7] {"123", "dot", "54773rt", "))", "hello", "Hi", "1&7"};
string[] array2 = new string[array1.Length];
void Function (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Function(array1, array2);
Print(array2);


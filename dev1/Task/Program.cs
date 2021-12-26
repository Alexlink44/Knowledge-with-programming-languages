int[] NewArray()
{
    int[] array = new int[new Random().Next(3, 10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i > 0 && i < (arr.Length - 1) && i != (arr.Length)) { Console.Write($"{arr[i]}, "); }
        else if (arr.Length == 1) {Console.Write($"[{arr[i]}]");}
        else if (i == 0) { Console.Write($"[{arr[i]}, "); }
        else { Console.Write($"{arr[i]}]"); }
    }
}

int[] EvenArray(int[] array)
{
    int[] evenArr = new int[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Array.Resize(ref evenArr, count + 1);
            evenArr[count] = array[i];
            count++;
        }
    }
    return evenArr;
}

int[] array = NewArray();
PrintArray(array);
array = EvenArray(array);
Console.WriteLine();
PrintArray(array);
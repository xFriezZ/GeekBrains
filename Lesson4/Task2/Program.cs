int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
PrintResult(array);



static void PrintResult(int[] array)
{
    int countNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countNum++;
        }
    }
    Console.WriteLine(countNum);
}
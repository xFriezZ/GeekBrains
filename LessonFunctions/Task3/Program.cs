int[] array = new int[7];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
csda(array);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");

static int[] csda(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int a = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = a;
    }
    return array;
}
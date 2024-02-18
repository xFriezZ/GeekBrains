Console.WriteLine("Введите строчный массив где элементы разделены пробелом");
string[] arrayStr = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' });

string[] testArray = ["1234", "1567", "-2", "computer science"];

PrintResultArray(ArrayConversion(arrayStr));


static string[] ArrayConversion(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            size++;
        }
    string[] tmp = new string[size];
    int tmpSize = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            tmp[tmpSize] = array[j];
            tmpSize++;
        }
    }
    return tmp;
}

static void PrintResultArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length == 1)
            {
                Console.Write("[“" + array[i] + "”]");
            }
            else if (i == 0)
            {
                Console.Write("[“" + array[i] + "”, “");
            }
            else if (i != array.Length - 1)
            {
                Console.Write(array[i] + "”, “");
            }
            else
            {
                Console.WriteLine(array[i] + "”]");
            }
        }
    }
}
# **Final** **Work**

## *Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.**

### Решение задачи по этапам

1. Задать массив или получить через консоль
``` 
string[] testArray = ["1234", "1567", "-2", "computer science"];

tring[] arrayStr = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' });
``` 
2. Получить количество элементов длина которых меньше, либо равна 3 символам с помощью метода ***DeterminingArraySize*** в который передаётся ***заданный массив*** или ***полученный с консоли*** и записать полученный размер в переменную ***arraySize***
``` 
int arraySize = DeterminingArraySize(testArray);

static int DeterminingArraySize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            size++;
        }
    return size;
}
``` 
3. Получить сформированный новый массив из строк согласно условиям задачи с помощью метода ***ArrayConversion*** передав в него ***заданный массив*** или ***полученный с консоли*** и полученный на этапе 2 ***arraySize***
``` 
static string[] ArrayConversion(string[] array, int size)
{
    string[] tmp = new string[size];
    int tmpSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tmp[tmpSize] = array[i];
            tmpSize++;
        }
    }
    return tmp;
}
``` 
4. Вывести сформированный массив в консоль переда в него сформированный массив с помощью метода ***PrintResultArray***
``` 
PrintResultArray(ArrayConversion(testArray, arraySize));

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
``` 
# **Блок-схема основной содержательной части**
![Блок-схема](/images/FinalWorkDiagram.png)

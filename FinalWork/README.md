# **Final** **Work**

## *������: �������� ���������, ������� �� ���������� ������� ����� ��������� ����� ������ �� �����, ����� ������� ������, ���� ����� 3 ��������. �������������� ������ ����� ������ � ����������, ���� ������ �� ������ ���������� ���������. ��� ������� �� ������������� ������������ �����������, ����� �������� ������������� ���������.**

### ������� ������ �� ������

1. ������ ������ ��� �������� ����� �������
``` 
string[] testArray = ["1234", "1567", "-2", "computer science"];

tring[] arrayStr = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' });
``` 
2. �������� ���������� ��������� ����� ������� ������, ���� ����� 3 �������� � ������� ������ ***DeterminingArraySize*** � ������� ��������� ***�������� ������*** ��� ***���������� � �������*** � �������� ���������� ������ � ���������� ***arraySize***
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
3. �������� �������������� ����� ������ �� ����� �������� �������� ������ � ������� ������ ***ArrayConversion*** ������� � ���� ***�������� ������*** ��� ***���������� � �������*** � ���������� �� ����� 2 ***arraySize***
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
4. ������� �������������� ������ � ������� ������ � ���� �������������� ������ � ������� ������ ***PrintResultArray***
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
                Console.Write("[�" + array[i] + "�]");
            }
            else if (i == 0)
            {
                Console.Write("[�" + array[i] + "�, �");
            }
            else if (i != array.Length - 1)
            {
                Console.Write(array[i] + "�, �");
            }
            else
            {
                Console.WriteLine(array[i] + "�]");
            }
        }
    }
}
``` 
# **����-����� �������� �������������� �����**
![����-�����](/images/FinalWorkDiagram.png)

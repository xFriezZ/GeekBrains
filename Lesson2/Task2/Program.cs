
Console.WriteLine("Введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());
while (x == 0 || y == 0)
{
    if (x == 0)
    {
        Console.WriteLine("Вы ввели x = 0 \nВведите координату X != 0");
        x = Convert.ToInt32(Console.ReadLine());
    }
    if (y == 0)
    {
        Console.WriteLine("Вы ввели y = 0 \nВведите координату Y != 0");
        y = Convert.ToInt32(Console.ReadLine());
    }
}
if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}

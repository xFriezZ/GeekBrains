while (true)
{
    Console.WriteLine("Введите целое число");
    string number = Console.ReadLine();
    bool numberIsANumber = int.TryParse(number, out var number1);
    while (!numberIsANumber)
    {
        Console.WriteLine("Введите целое число");
        Console.WriteLine("Для выхода из цикла введти 'q' или число сумма цифр которого будет четным");
        number = Console.ReadLine();
        numberIsANumber = int.TryParse(number, out var number2);
        if (numberIsANumber == true || number == "q")
        {
            break;
        }
    }
    if (evenNumber(number) || number == "q")
    {
        break;
    }

}
Console.WriteLine("Вы вышли из цикла!");

static bool evenNumber(string number)
{
    int a = 0;
    for (int i = 0; i < number.Length; i++)
    {
        a = a + number[i];
    }
    return a % 2 == 0;
}
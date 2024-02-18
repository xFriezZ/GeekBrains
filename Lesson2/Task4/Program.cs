string? number = Console.ReadLine();
bool numberIsANumber = int.TryParse(number, out var number1);
while (numberIsANumber == false)
{
    Console.WriteLine("Введите любое натуральное число");
    number = Console.ReadLine();
    numberIsANumber = int.TryParse(number, out var number2);
}
if (number.Length >= 2)
{
    for (int i = 0; i < number.Length - 1; i++)
    {
        Console.Write(number[i] + ",");
    }
    Console.Write(number[number.Length - 1]);
}
else if (number.Length == 1)
{
    Console.WriteLine(number);
}
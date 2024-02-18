Console.WriteLine("Введите число >= 10 и =< 99:");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10 || number > 99)
{
    if (number < 10)
    {
        Console.WriteLine("Ваше число меньше 10\nВведите число от 10 до 99");
        number = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Ваше число больше 99 \nВведите число от 10 до 99");
        number = Convert.ToInt32(Console.ReadLine());
    }
}
int firstNumber = number / 10 % 10;
int secondNumber = number % 10;
if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

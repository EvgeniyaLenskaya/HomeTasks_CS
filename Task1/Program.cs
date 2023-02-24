Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB>numberA)
{
    Console.WriteLine(numberB + " - максимальное число");
}

else
{
    Console.WriteLine(numberA + " - максимальное число");
}
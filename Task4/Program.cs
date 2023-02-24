Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    number = number * (-1);
}
int i = 1;
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
}

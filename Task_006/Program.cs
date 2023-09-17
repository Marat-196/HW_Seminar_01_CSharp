Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA % 2 == 0)
{
    Console.WriteLine($"{numA} -> Да");
}
else
{
    Console.WriteLine($"{numA} -> Нет");
}

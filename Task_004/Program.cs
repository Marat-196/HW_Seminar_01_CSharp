Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

int mx = numA;

if (numA > mx) mx = numA;
if (numB > mx) mx = numB;
if (numC > mx) mx = numC;

Console.WriteLine($"max = {mx}");
// ЗАДАНИЕ 10(Б)

double x = 0;
double y = 0;

Console.WriteLine($"Введите x: ");
double.TryParse(Console.ReadLine(), out x);

if (x <= 0)
    y = 0;
if (x > 0 && y <= 1)
    y = x;
if (x > 1)
    y = Math.Pow(x, 4);

Console.WriteLine($"y = {y}");

// 3.4
double x1 = 2;
double x2 = 3;
double dx = 0.2;
Console.WriteLine("введите х1");
if (!double.TryParse(Console.ReadLine(), out x1)) x1 = 2;
Console.WriteLine("введите х2");
if (!double.TryParse(Console.ReadLine(), out x2)) x2 = 3;
Console.WriteLine("введите dх");
if (!double.TryParse(Console.ReadLine(), out dx)) dx = 0.2;

Console.WriteLine("e^(x^2)/2");


for (double x = x1; x <= x2; x += dx)
{
    double y = (Math.Exp(Math.Pow(x, 2)))/2;
    Console.WriteLine($"x: {Math.Round(x, 2)}\ty: {y}");
}


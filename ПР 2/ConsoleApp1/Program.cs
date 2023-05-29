// ЗАДАНИЕ 5(А)

void SetValue(ref double var, string VarName)
{
    Console.WriteLine($"введите {VarName}: ");
    if (!Double.TryParse(Console.ReadLine(), out var))
    {


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Значение переменной введено неверно!");
        Console.ForegroundColor = ConsoleColor.White;
        SetValue(ref var, VarName);
    }
}

double x = 0;
double y = 0;
double z = 0;
double w = 0;

SetValue(ref x, "x");
SetValue(ref y, "y");
SetValue(ref z, "z");

w = Math.Sin(Math.Abs( (y - Math.Sqrt(Math.Abs(x))) * (x - y/(z * z + x * x / 4)) ) );
Console.WriteLine($"w= {w}");

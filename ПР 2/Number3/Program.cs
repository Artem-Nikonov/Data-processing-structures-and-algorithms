//Задание 11(Г)

double x = 0;
double y = 0;
Console.WriteLine("Введите x: ");
double.TryParse(Console.ReadLine(), out x);
Console.WriteLine("Введите y: ");
double.TryParse(Console.ReadLine(), out y);

double w = x * x + y * y;

if (w < 1 && ((x<0 && y>=-1*x) || (x>0 && y<=-1*x) || (x==0 && y==0)) )
    Console.WriteLine("Точка попадает внутрь области.");
else
    Console.WriteLine("Точка не попадает внутрь области.");

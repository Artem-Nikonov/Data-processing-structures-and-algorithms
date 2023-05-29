//1(Г)
uint n;
double res = 0;
double eps = 0.000000001;
Console.WriteLine("Введите n: ");
if(!uint.TryParse(Console.ReadLine(), out n)) n = 1;
res = Math.Pow(-1, 0) / (2);

for (int i = 2; i<= n ; i++)
{
    double mean = res + Math.Pow(-1, (i + 1) % 2) / (i * (i + 1));
    if (Math.Abs(res - mean) < eps) break;
    res = mean;
}
Console.WriteLine(res);
uint m = 1;
double x = 0;
Console.WriteLine("Введите m: ");
uint.TryParse(Console.ReadLine(), out m);
Console.WriteLine("Введите x: ");
double.TryParse(Console.ReadLine(), out x);

double LastPow = x;
uint LastFact = 1;
double res = x;

for (uint i = 2; i<=m; i++)
{
    double pow = LastPow * x * x * -1; 
    LastPow = pow;
    uint fact = LastFact * (2*i - 2)*(2*i - 1);
    LastFact = fact;
    Console.WriteLine($"{pow}\t{fact}");
    res += pow / fact;  
}

Console.WriteLine(res);

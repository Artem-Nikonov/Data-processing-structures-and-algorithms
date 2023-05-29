double eps = 0.0001;
double x = 0;

while (true)
{
    Console.WriteLine("Введите x: ");
    double.TryParse(Console.ReadLine(), out x);
    Console.WriteLine("Введите eps: ");
    double.TryParse(Console.ReadLine(), out eps);
    eps = Math.Abs(eps);

    double lastpow = 1;
    double lastfact = 1;
    double result = 1;

    for (int m = 1; ; m++)
    {
        double pow = lastpow * (x * x);
        double fact = lastfact * (2*m * (2*m - 1));
        double res = pow / fact;

        if (Math.Abs(res) < eps) break;

        
        lastpow= pow;
        lastfact= fact;
        result += res;
        Console.WriteLine($"{result}");
    }

    double realresult = (Math.Exp(x) + Math.Exp(-x)) / 2;
    double error = Math.Abs(result - realresult);

    Console.WriteLine("результат:"+ result);
    Console.WriteLine("точный результат:" + realresult);
    Console.WriteLine("погрешность:"+ error);
}




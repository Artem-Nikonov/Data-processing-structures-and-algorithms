namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.0001;
            double x = 0;

            while (true)
            {
                Console.WriteLine("Введите eps: ");
                double.TryParse(Console.ReadLine(), out eps);
                eps = Math.Abs(eps);
                Console.WriteLine("Введите x: ");
                double.TryParse(Console.ReadLine(), out x);

                double lastfact = 1;
                double lastpow = Math.Pow(x / 2, 2);
                double result = lastfact * lastpow;

                for (int k = 1; ; k++)
                {
                    double fact = lastfact * Math.Pow(k + 1, 2);
                    double pow = lastpow * Math.Pow(x / 2, 2);
                    double znak = Math.Pow(-1, k % 2);
                    double res = znak / fact * pow;

                    if (Math.Abs(res) < eps) break;

                    result += res;
                    lastfact = fact;
                    lastpow = pow;

                }
                Console.WriteLine("результат:", result);
            }
            

        }
    }
}
uint n = 1;

Console.WriteLine("Введите размерность массива");
uint.TryParse(Console.ReadLine(), out n);

double[] array = new double[n];

for (int i =(int)n-1 ;i >= 0; i--)
{
    double.TryParse(Console.ReadLine(), out array[i]);
}
for (uint i = 0; i < n; i++)
{
    Console.Write(array[i]+" ");
}

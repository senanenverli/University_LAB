using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 0.7;
        double epsilon = 0.01;
        double sum = 0;
        double term;
        int n = 1;

        do
        {
            term = Math.Pow(-1, n - 1) * Math.Sin(Math.Pow(x, n) / n);
            sum += term;
            n++;
        } while (Math.Abs(term) >= epsilon);

        Console.WriteLine("Sum of the series: " + sum);
    }
}

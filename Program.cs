StreamWriter sw = new StreamWriter("C:/Users/prdb/Desktop/ConsoleApp8/test.txt");
Console.WriteLine("Введите верхний и нижний предел интеграла соответственно (a и b) через пробел: ");
string[] input = Console.ReadLine().Split(" ");
double a = Convert.ToDouble(input [0]);
double b = Convert.ToDouble(input[1]);
   
    if (a > b)
    {
        Console.WriteLine("Не верно введены значения должно быть a < b");
        return;
    }

    Console.WriteLine("Введите количество разбиений n: ");
    int n = Convert.ToInt32(Console.ReadLine());


    static double Fun(double x)
    {
        return 2 * Math.Pow(x, 2) + 3 * x;
    }

    static double Rect(double a, double b, int n)
    {

        double h = (b - a) / n;
        double S = 0.0;

        for (int i = 0; i <= n; i++)
        {
            double Mid = a + i * (h/2) ;
            S += Mid;
        }

        S *= h;
        return S;

    }

    double integral = Rect(a, b, n);
    Console.WriteLine($"Значение определенного интеграла от {a} до {b} равно: {integral:F2}");
    sw.WriteLine($"Значение определенного интеграла от {a} до {b} равно: {integral:F2}");
sw.Close();





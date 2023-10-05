//Вариант 6, Средний уровень
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x: ");
double x = int.Parse(Console.ReadLine());

double a, b, z;

switch (n)
{
    case 1:
        {
            a = -5;
            b = 2.5;
            z = Math.Log(Math.Abs(b * Math.Pow(x, 3)));
            if (x < a) Console.WriteLine(2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z);
            else if (a <= x && x <= b * b) Console.WriteLine(z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.Log(z));
            else if (x > (b * b)) Console.WriteLine(Math.Exp(2.5 * a * x) + z * a * b * x);
            break;
        }

    case 2:
        {
            a = 3;
            b = 5;
            z = Math.Log(Math.Abs(b * x));
            if (x < a) Console.WriteLine(2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z);
            else if (a <= x && x <= b * b) Console.WriteLine(z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.Log(z));
            else if (x > (b * b)) Console.WriteLine(Math.Exp(2.5 * a * x) + z * a * b * x);
            break;
        }

    case 3:
        {
            a = -10;
            b = 3;
            z = Math.Log(Math.Abs(b * Math.Pow(x, 2)));
            if (x < a) Console.WriteLine(2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z);
            else if (a <= x && x <= b * b) Console.WriteLine(z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.Log(z));
            else if (x > (b * b)) Console.WriteLine(Math.Exp(2.5 * a * x) + z * a * b * x);
            break;
        }
}

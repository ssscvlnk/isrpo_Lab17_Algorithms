double Sum(double a, double b)
{
    return a + b;
}
double Multiplication(double a, double b)
{
    return a * b;
}
double Division(double a, double b)
{
    return a / b;
}
double Subtraction(double a, double b)
{
    return a - b;
}
Console.Write("Введите 1-ое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double addition = Sum(num1, num2);
double multiplication = Multiplication(num1, num2);
double division = Division(num1, num2);
double subtraction = Subtraction(num1, num2);
Console.WriteLine($"{num1} + {num2} = {addition}");
Console.WriteLine($"{num1} - {num2} = {subtraction}");
Console.WriteLine($"{num1} * {num2} = {multiplication}");
Console.WriteLine($"{num1} / {num2} = {division}");

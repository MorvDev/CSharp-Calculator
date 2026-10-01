using System;
class Subjects
{
    public class Math
    {
        public int Sum(int a, int b) { return a + b; }
        public int Sub(int a, int b) { return a - b; }
        public int Mul(int a, int b) { return a * b; }
        public int Div(int a, int b) { return a / b; }
    }
}
class Program
{
    static void Main()
    {
        Subjects.Math clsMath = new Subjects.Math();

        Console.Write("Введите первое число: ");
        string num1 = Console.ReadLine();

        Console.Write("Введите второе число: ");
        string num2 = Console.ReadLine();

        Console.Write("Выберите знак (+, -, , /): ");
        string znak = Console.ReadLine();

        if (znak == "+") Console.WriteLine(clsMath.Sum(int.Parse(num1), int.Parse(num2)));
        if (znak == "-") Console.WriteLine(clsMath.Sub(int.Parse(num1), int.Parse(num2)));
        if (znak == "") Console.WriteLine(clsMath.Mul(int.Parse(num1), int.Parse(num2)));
        if (znak == "/") Console.WriteLine(clsMath.Div(int.Parse(num1), int.Parse(num2)));
    }
}
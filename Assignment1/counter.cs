using System;

class Calculator
{
    static void Main()
    {
        try
        {
            Console.Write("请输入第一个数字: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("请输入运算符 (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("请输入第二个数字: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Subtract(num1, num2);
                    break;
                case '*':
                    result = Multiply(num1, num2);
                    break;
                case '/':
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Error: Wrong Operator!");
                    return;
            }
            Console.WriteLine($"计算结果: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please import right numbers");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Wrong divisor ");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
    static double Add(double x, double y)
    {
        return x + y;
    }
    static double Subtract(double x, double y)
    {
        return x - y;
    }
    static double Multiply(double x, double y)
    {
        return x * y;
    }
    static double Divide(double x, double y)
    {
        if (y != 0)
            return x / y;
        else
            throw new DivideByZeroException();
    }
}
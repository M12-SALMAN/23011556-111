using System;

public class Class2
{
	public Class2()
	{
        double num1, num2, result = 0;
        char operation;

        Console.WriteLine("=== Simple Calculator ===");

        
        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        
        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                }
                break;

            default:
                Console.WriteLine("Invalid operation. Please use +, -, *, or /.");
                break;
        }
    }
}
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== C# Console Calculator ===");
        Console.WriteLine("Type 'exit' as the first number to quit.\n");

        while (true)
        {
            // --- First Number ---
            Console.Write("Enter first number (or 'exit' to quit): ");
            string input1 = Console.ReadLine();

            if (input1.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (!double.TryParse(input1, out double num1))
            {
                Console.WriteLine("Invalid number. Please try again.\n");
                continue;
            }

            // --- Second Number ---
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            if (!double.TryParse(input2, out double num2))
            {
                Console.WriteLine("Invalid number. Please try again.\n");
                continue;
            }

            // --- Operator ---
            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine().Trim();

            // --- Calculation ---
            double result;

            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.\n");
                    continue;
                }
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid operator. Use +, -, *, or /.\n");
                continue;
            }

            Console.WriteLine($"Result: {result}\n");
        }
    }
}

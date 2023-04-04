namespace Exercise_5
{
   

  
        class Calculator
        {
            public double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Sub(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Mul(double num1, double num2)
            {
                return num1 * num2;
            }

            public double Div(double num1, double num2)
            {
                if (num2 == 0)
                {
                    throw new Exception("Cannot divide by zero.");
                }

                return num1 / num2;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the operation to perform (+, -, *, /): ");
                char operation = Convert.ToChar(Console.ReadLine());

                Calculator calculator = new Calculator();

                double result = 0;

                try
                {
                    switch (operation)
                    {
                        case '+':
                            result = calculator.Add(num1, num2);
                            break;
                        case '-':
                            result = calculator.Sub(num1, num2);
                            break;
                        case '*':
                            result = calculator.Mul(num1, num2);
                            break;
                        case '/':
                            result = calculator.Div(num1, num2);
                            break;
                        default:
                            throw new Exception("Invalid operation.");
                    }

                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.ReadKey();
            }
        }
    }


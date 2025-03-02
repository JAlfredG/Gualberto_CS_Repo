namespace firstProject
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        break;
                    } else
                    {
                        Console.WriteLine(num1 / num2);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

        }
    }
}

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter second number");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter operation + , - , * , /");
            char oper = (char)Console.Read();

            double result = 0;

            switch (oper)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
                default: Console.WriteLine("not found"); break;
            }

            Console.WriteLine(result);

        }
    }
}

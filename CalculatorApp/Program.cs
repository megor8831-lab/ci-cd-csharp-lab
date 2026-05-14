namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(6, 7));

            int difference = calc.Subtract(7, 6);
            Console.WriteLine(difference);
        }
    }
}
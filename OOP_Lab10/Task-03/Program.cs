class Program
{
    public static void Main(string[] args)
    {
        ICalculator calculator = new Calculator(new AdditionStrategy());
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();

            if (tokens[0] == "mode")
            {
                string operator_1 = tokens[1];
                ICalculationStrategy strategy = null;

                switch (operator_1)
                {
                    case "+":
                        strategy = new AdditionStrategy();
                        break;
                    case "-":
                        strategy = new SubtractionStrategy();
                        break;
                    case "*":
                        strategy = new MultiplicationStrategy();
                        break;
                    case "/":
                        strategy = new DivisionStrategy();
                        break;
                }
                calculator.ChangeStrategy(strategy);
            }
        }
    }
}
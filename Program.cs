public class Program
{
    public static void Main(string[] args)
    {
        
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть перше число: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            double secondNumber = double.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Виберіть тип математичної дії ( додавання(+); віднімання(-); множення(*); ділення(/) ): ");
            char typeOfMathActivity = char.Parse(Console.ReadLine());
            Console.WriteLine("Розрахунок: ");

            if (typeOfMathActivity == '+')
            {
                double result1 = firstNumber + secondNumber;
                Console.WriteLine($"{firstNumber} + {secondNumber} = {result1}");
            }
            else if (typeOfMathActivity == '-')
            {
                double result2 = firstNumber - secondNumber;
                Console.WriteLine($"{firstNumber} - {secondNumber} = {result2}");
            }
            else if (typeOfMathActivity == '*')
            {
                double result3 = firstNumber * secondNumber;
                Console.WriteLine($"{firstNumber} * {secondNumber} = {result3}");
            }
            else if (typeOfMathActivity == '/')
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Ділення на нуль неможливе!");
                } 
                else
                {
                    double result4 = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result4}");
                }  
            }
        } while (true);
    }
}
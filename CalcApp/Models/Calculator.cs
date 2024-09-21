using System.Data;

namespace CalcApp.Models
{
    internal class Calculator
    {
        public List<string> operationsHistory { get; private set; }

        public Calculator()
        {
            operationsHistory = new List<string>();
        }

        public void Operation()
        {
            Console.WriteLine("************* Calculator *************");
            string mathOperation = Console.ReadLine();
            try
            {
                var result = new DataTable().Compute(mathOperation, null);
                operationsHistory.Add(mathOperation + "=" + result);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid expression, please try again\nException -> {e}");
            }
        }
        public void ShowHistory()
        {
            Console.Clear();
            Console.WriteLine("Showing history");
            foreach ( var operation in operationsHistory )
            {
                Console.WriteLine($"{operation}\n");
            }
        }

        public void ClearHistory()
        {
            Console.Clear();
            operationsHistory.Clear();
        }
    }
}

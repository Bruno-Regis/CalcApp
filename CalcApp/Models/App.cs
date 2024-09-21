using System.ComponentModel;

namespace CalcApp.Models
{
    internal class App
    {
        public Calculator calculator = new();
        enum MenuOption { Calculate = 1, ShowHistory  = 2, ClearHistory = 3, Quit = 4 }
        public void ShowMenu()
        {
            bool loop = true;
            while (loop == true)
            {
                calculator.Operation();
                Console.WriteLine("keep calculating? (1) Yes (2) Show History (3) Clear History (4) Quit");
                if(int.TryParse(Console.ReadLine(), out int menuOption)) // if parse is possible, we return menuOption as integer
                {
                    // Casting menuOption from int to MenuOption enum
                    switch ((MenuOption)menuOption)
                    {
                        case MenuOption.Calculate:
                            Console.Clear();
                            break;
                        case MenuOption.ShowHistory:
                            if (calculator.operationsHistory.Count > 0)
                            {                                
                                calculator.ShowHistory();
                            }
                            else
                            {
                                Console.WriteLine("No history avaiable");
                            }
                            break;
                        case MenuOption.ClearHistory:
                            if (calculator.operationsHistory.Count > 0)
                            {                               
                                calculator.ClearHistory();
                                Console.WriteLine("History already cleared");
                            }
                            else
                            {
                                Console.WriteLine("History is already empty");
                            }
                            break;

                        case MenuOption.Quit:
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Option, please try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number - from 1 to 4");
                }
            }
        }
    }
}

menu();

static void menu()
{
    Console.WriteLine("Welcome!");
    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1 - Sum");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Exit");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Multiplication(); break;
        case 4: Division(); break;
        case 5: System.Environment.Exit(0); break;
        default: Console.WriteLine("Invalid choice!"); menu(); break;
    }
}
static void Subtraction()
{
    Console.Clear();
    bool loop = true;
    float total = 0;
    bool control = true;
    Console.WriteLine("Perform the subtraction operation (type nothing when youre done)");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("Type a value: ");
    string input = Console.ReadLine();
    float value1 = float.Parse(input);

    while (loop == true)
    {
        if (control == true)
        {
            Console.WriteLine("Subtract from the previous result:");
            control = false;
            total = value1;
        }
        Console.WriteLine($"{total} minus:");
        string input2 = Console.ReadLine();
        if (string.IsNullOrEmpty(input2))
        {
            break;
        }
        float value2 = float.Parse(input2);
        total -= value2;
    }
    Console.WriteLine($"{total}");
    Console.WriteLine($"The result of the subtraction is: {total}");
    Console.ReadKey();
}
static void Sum()
{
    Console.Clear();
    float total = 0;
    bool loop = true;
    bool control = true;
    int n = 1;
    while (loop == true)
    {
        if (control == true)
        {
            Console.WriteLine("Perform the sum operation (type nothing when youre done)");
            Console.WriteLine("*********************************************************");
            control = false;
        }
        Console.WriteLine($"{n}º value: ");
        string input = Console.ReadLine();
        Console.WriteLine("");
        if (string.IsNullOrEmpty(input))
        {
            break;
        }
        float value1 = float.Parse(input);
        total = value1 + total;
        n++;
    }
    Console.WriteLine($"The total sum is: {total}");
    Console.ReadKey();
}
static void Division()
{
    Console.Clear();
    Console.WriteLine("Type a value: ");
    float value1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Type a value: ");
    float value2 = float.Parse(Console.ReadLine());
    float result = value1 / value2;
    Console.WriteLine($"The result of the Division is: {result}");
    Console.ReadKey();
}
static void Multiplication()
{
    Console.Clear();
    float total = 1;
    bool loop = true;
    bool control = true;

    while (loop)
    {

        if (control == true)
        {
            Console.WriteLine("Perform the multiplication operation (type nothing when youre done)");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Type a value: ");
            string input1 = Console.ReadLine();
            if (string.IsNullOrEmpty(input1)) break;
            float value1 = float.Parse(input1);
            total = value1;
            control = false;
        }

        Console.WriteLine("Multiplicated per :");
        string input2 = Console.ReadLine();
        if (string.IsNullOrEmpty(input2)) break;

        float value2 = float.Parse(input2);
        total = total * value2;
        Console.WriteLine($" = {total}");
    }
    Console.WriteLine($"The final result of the Multiplication is: {total}");
    Console.ReadKey();
}
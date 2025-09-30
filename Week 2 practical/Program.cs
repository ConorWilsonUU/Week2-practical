/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Auther: Mr Conor Wilson
 * Date: 30/09/25
 * */

Main();

void Main()
{
    PrintMenu();
    int option = Convert.ToInt32(Console.ReadLine());
    InputOption(option);
    GetMessage(option);
}


    // Task 1

    // Method name should be PrintMenu()
    // Method should be void
    // Should have the same display as example

void PrintMenu()
{
    Console.WriteLine("Please enter a vlaid option from below:");
    Console.WriteLine("1. Hello on French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit applicaiton");
}

    // Task 2

    // Method Name should be InputOption()
    // Will take user input and produce the answer they need
    // E.G User input goes into InputOption,
    // return it to Main(), store from InputOption into
    // option named varible
    // Add try-catch


int InputOption(int a)
{
    try
    {
        if (a == 0 || a == 1 || a == 2 || a == 3 || a == 4)
        {
        return a;
        }
        else
        {
        return -1;
        }
    }
    catch ( Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
    return a;
}


    // Task 3

    // Method name should be GetMessage()
    // Use a switch statement
    // Return hello in language

void GetMessage(int a)
{
    string language = " ";
    switch (a)
    {
        case 0:
            language = "GoodBye";
            break;
        case 1:
            language = "Bonjour";
            break;
        case 2:
            language = "Ola";
            break;
        case 3:
            language = "Hallo";
            break;
        case 4:
            language = "Ciao";
            break;
        default:
            Console.WriteLine("Please enter a valid option");
            return;
    }
    Console.WriteLine($"{language}");
}



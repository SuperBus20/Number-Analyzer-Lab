Console.WriteLine("Welcome, what is your name?");
string userName = Console.ReadLine();
bool keepPlaying;

do
{
    Console.WriteLine("Enter a whole number between 1-100");
    int enteredNumber = Convert.ToInt32(Console.ReadLine());
    while (enteredNumber < 0 || enteredNumber > 101)
    {
        Console.WriteLine("Please enter a valid number");
        enteredNumber = Convert.ToInt32(Console.ReadLine());
    }
    keepPlaying = false;
    if (enteredNumber % 2 != 0 && enteredNumber < 60)
    {
        Console.WriteLine($"{userName}'s number is Odd and less than 60");
    }
    else if (enteredNumber % 2 == 0 && enteredNumber < 25)
    {
        Console.WriteLine($"{userName}'s number is Even and less than 25");
    }
    else if (enteredNumber % 2 == 0 && enteredNumber > 25 && enteredNumber < 61)
    {
        Console.WriteLine($"{userName}'s number is Even and between 26 and 60 inclusive.");
    }
    else if (enteredNumber % 2 == 0 && enteredNumber > 60)
    {
        Console.WriteLine($"{userName}'s number is Even and greater than 60");
    }
    else
    {
        Console.WriteLine($"{userName}'s number is Odd and greater than 60");
    }
    Console.WriteLine("Would you like the program to run again? (Y/N)");
    string runAgainAnswer = Console.ReadLine();
    if (runAgainAnswer.ToLower() == "y" || runAgainAnswer == "yes")
    {
        keepPlaying = true;
    }
    else
    {
        Console.WriteLine($"Have a great day {userName}");
    }
} while (keepPlaying == true);
string userPIN;

Console.WriteLine("Enter your PIN");
userPIN = Console.ReadLine();
while (true)
    
{
    if (userPIN == "1234")
    {
        Console.WriteLine("Welcome!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong PIN. Try again.");
    }
}
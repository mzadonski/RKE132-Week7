Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoice = Console.ReadLine();

if(userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBuy();
}



static void PrintHello()  //function / method
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodBuy()
{
    Console.WriteLine("See you later, aligator,");
}
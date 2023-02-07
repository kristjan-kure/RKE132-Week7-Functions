Console.WriteLine("Are you coming or leaving? (in/out):");
string answer = Console.ReadLine();

if (answer == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello() //function
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye() //function
{
    Console.WriteLine("See you later, alligator.");
}





//Total < 10 EUR, discount = 1%
//Total >= 10 && < 20 EUR, discount = 5%
//Total >= 20, discount = 10%

Console.WriteLine("Provide total:");
int userInput = Int32.Parse(Console.ReadLine());

double discount = calculateDiscount(userInput);
Console.WriteLine($"Your discount is: {discount}%");

double newTotal = calculateNewTotal(userInput, discount);
Console.WriteLine($"Your updated total with {discount}% is: {newTotal} EUR");

static double calculateDiscount(int totalValue) 
{
    if (totalValue < 10)
    {
        return 1;
    }
    else if (totalValue >= 10 && totalValue < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double calculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}
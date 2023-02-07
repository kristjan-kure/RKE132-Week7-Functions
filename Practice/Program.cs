Console.WriteLine("Enter temperature value:");
int tempValue = Int32.Parse(Console.ReadLine());

Console.WriteLine("Convert to Celsius or Farenheit (c/f):");
char tempConvertTo = char.Parse(Console.ReadLine().ToLower());

if (tempConvertTo == 'c')
{
    ConverToCelsius(tempValue);
}
else
{
    ConvertToFahrenheit(tempValue);
}

static void ConverToCelsius(int value) {
    double celsius = (value - 32) * 5 / 9;
    Console.WriteLine($"Your temperature in Farenheit: {value} °F");
    Console.WriteLine($"Your temperature in Celsius: {celsius} °C");
}

static void ConvertToFahrenheit(int value) {
    double fahrenheit = (value * 9) / 5 + 32;
    Console.WriteLine($"Your temperature in Celsius: {value} °C");
    Console.WriteLine($"Your temperature in Farenheit: {fahrenheit} °F");
}

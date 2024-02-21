//Tomas Bendaravicius
//Conversion unit app
using System;

class Temperature
{   
    // Temperature conversion methods
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    public static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    public static double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9 + 273.15;
    }

    public static double KelvinToFahrenheit(double fahrenheit)
    {
        return (fahrenheit - 273.15) * 9 / 5 + 32;
    }
}

class Distance
{
    // Distance conversion methods
    public static double MetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    public static double FeetToMeters(double feet)
    {
        return feet / 3.28084;
    }
}

class Weight
{
    // Weight conversion methods
    public static double KilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    public static double PoundsToKilograms(double pounds)
    {
        return pounds / 2.20462;
    }
}

//Main app
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n Welcome to the Unit Conversion app!");
        Console.ResetColor();
        

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n----------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPlease select an option:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n----------------------------------------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Temperature Conversion");
            Console.WriteLine("2. Distance Conversion");
            Console.WriteLine("3. Weight Conversion");
            Console.WriteLine("4. Exit\n");
            Console.ResetColor();

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input! Please enter a number.\n");
                Console.ResetColor();
                continue;
            }

            switch (choice)
            {
                case 1:
                    TemperatureConversion();
                    break;
                case 2:
                    DistanceConversion();
                    break;
                case 3:
                    WeightConversion();
                    break;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThank you for using Unit Conversion app\n");
                    Console.WriteLine("Exiting the program...\n");
                    Console.ResetColor();
                    return;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid option! Please select a valid option.");
                    Console.ResetColor();
                    break;
            }
        }
    }

    static void TemperatureConversion()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nTemperature Conversion");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.WriteLine("5. Fahrenheit to Kelvin");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        Console.WriteLine("\nEnter option: ");
        Console.ResetColor();

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5 && choice != 6 ))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid choice! Please enter selection between 1 - 6.");
            Console.ResetColor();
            return;
        }

        double input, result;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nEnter temperature: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid input! Please enter a valid number.");
            Console.ResetColor();
            return;
        }

        switch (choice)
        {
            case 1:
                result = Temperature.CelsiusToFahrenheit(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Celsius is equal to {result} Fahrenheit.");
                break;
            case 2:
                result = Temperature.FahrenheitToCelsius(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Fahrenheit is equal to {result} Celsius.");
                break;
            case 3:
                result = Temperature.CelsiusToKelvin(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Celsius is equal to {result} Kelvin.");
                break;
            case 4:
                result = Temperature.KelvinToCelsius(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Kelvin is equal to {result} Celsius.");
                break;
            case 5:
                result = Temperature.FahrenheitToKelvin(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Fahrenheit is equal to {result} Kelvin.");
                break;
            case 6:
                result = Temperature.KelvinToFahrenheit(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Kelvin is equal to {result} Fahrenheit.");
                break;
        }
    }

    static void DistanceConversion()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nDistance Conversion");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Meters to Feet");
        Console.WriteLine("2. Feet to Meters");
        Console.WriteLine("\nEnter option: ");
        Console.ResetColor();

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid choice! Please enter 1 or 2.");
            Console.ResetColor();
            return;
        }

        double input, result;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nEnter distance: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid input! Please enter a valid number.");
            Console.ResetColor();
            return;
        }

        switch (choice)
        {
            case 1:
                result = Distance.MetersToFeet(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Meters is equal to {result} Feet.");
                break;
            case 2:
                result = Distance.FeetToMeters(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Feet is equal to {result} Meters.");
                break;
        }
    }

    static void WeightConversion()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nWeight Conversion");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Kilograms to Pounds");
        Console.WriteLine("2. Pounds to Kilograms");
        Console.WriteLine("\nEnter option: ");
        Console.ResetColor();

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid choice! Please enter 1 or 2.");
            Console.ResetColor();
            return;
        }

        double input, result;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n----------------------------------------");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("\nEnter weight: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInvalid input! Please enter a valid number.");
            Console.ResetColor();
            return;
        }

        switch (choice)
        {
            case 1:
                result = Weight.KilogramsToPounds(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Kilograms is equal to {result} Pounds.");
                break;
            case 2:
                result = Weight.PoundsToKilograms(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"\n{input} Pounds is equal to {result} Kilograms.");
                break;
        }
    }
}

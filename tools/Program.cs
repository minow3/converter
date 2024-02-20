using System;

class Converter
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

    // Distance conversion methods
    public static double MetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    public static double FeetToMeters(double feet)
    {
        return feet / 3.28084;
    }

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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Conversion Program!");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Temperature Conversion");
            Console.WriteLine("2. Distance Conversion");
            Console.WriteLine("3. Weight Conversion");
            Console.WriteLine("4. Exit");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
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
                    Console.WriteLine("Exiting the program...");
                    return;
                default:
                    Console.WriteLine("Invalid option! Please select a valid option.");
                    break;
            }
        }
    }

    static void TemperatureConversion()
    {
        Console.WriteLine("\nTemperature Conversion");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
            return;
        }

        double input, result;
        Console.Write("Enter temperature: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        switch (choice)
        {
            case 1:
                result = Converter.CelsiusToFahrenheit(input);
                Console.WriteLine($"{input} Celsius is equal to {result} Fahrenheit.");
                break;
            case 2:
                result = Converter.FahrenheitToCelsius(input);
                Console.WriteLine($"{input} Fahrenheit is equal to {result} Celsius.");
                break;
        }
    }

    static void DistanceConversion()
    {
        Console.WriteLine("\nDistance Conversion");
        Console.WriteLine("1. Meters to Feet");
        Console.WriteLine("2. Feet to Meters");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
            return;
        }

        double input, result;
        Console.Write("Enter distance: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        switch (choice)
        {
            case 1:
                result = Converter.MetersToFeet(input);
                Console.WriteLine($"{input} Meters is equal to {result} Feet.");
                break;
            case 2:
                result = Converter.FeetToMeters(input);
                Console.WriteLine($"{input} Feet is equal to {result} Meters.");
                break;
        }
    }

    static void WeightConversion()
    {
        Console.WriteLine("\nWeight Conversion");
        Console.WriteLine("1. Kilograms to Pounds");
        Console.WriteLine("2. Pounds to Kilograms");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
            return;
        }

        double input, result;
        Console.Write("Enter weight: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        switch (choice)
        {
            case 1:
                result = Converter.KilogramsToPounds(input);
                Console.WriteLine($"{input} Kilograms is equal to {result} Pounds.");
                break;
            case 2:
                result = Converter.PoundsToKilograms(input);
                Console.WriteLine($"{input} Pounds is equal to {result} Kilograms.");
                break;
        }
    }
}

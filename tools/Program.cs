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
            Console.WriteLine("4. Exit\n");

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
        Console.WriteLine("3. Celsius to Kelvin");
        Console.WriteLine("4. Kelvin to Celsius");
        Console.WriteLine("5. Fahrenheit to Kelvin");
        Console.WriteLine("6. Kelvin to Fahrenheit");
        

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice) || (choice !<= 1 && choice !>= 6))
        {
            Console.WriteLine("Invalid choice! Please enter selection between 1 - 6.");
            return;
        }

        double input, result;
        Console.Write("\nEnter temperature: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        switch (choice)
        {
            case 1:
                result = Converter.CelsiusToFahrenheit(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Celsius is equal to {result} Fahrenheit.");
                break;
            case 2:
                result = Converter.FahrenheitToCelsius(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Fahrenheit is equal to {result} Celsius.");
                break;
            case 3:
                result = Converter.CelsiusToKelvin(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Celsius is equal to {result} Kelvin.");
                break;
            case 4:
                result = Converter.KelvinToCelsius(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Kelvin is equal to {result} Celsius.");
                break;
            case 5:
                result = Converter.FahrenheitToKelvin(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Fahrenheit is equal to {result} Kelvin.");
                break;
            case 6:
                result = Converter.KelvinToFahrenheit(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Kelvin is equal to {result} Fahrenheit.");
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
        Console.Write("\nEnter distance: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        switch (choice)
        {
            case 1:
                result = Converter.MetersToFeet(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Meters is equal to {result} Feet.");
                break;
            case 2:
                result = Converter.FeetToMeters(input);
                result = Math.Round(result, 2);
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
        Console.Write("\nEnter weight: ");
        if (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
            return;
        }

        switch (choice)
        {
            case 1:
                result = Converter.KilogramsToPounds(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Kilograms is equal to {result} Pounds.");
                break;
            case 2:
                result = Converter.PoundsToKilograms(input);
                result = Math.Round(result, 2);
                Console.WriteLine($"{input} Pounds is equal to {result} Kilograms.");
                break;
        }
    }
}

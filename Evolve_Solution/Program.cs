// See https://aka.ms/new-console-template for more information
var result = Question1.EvensOnly(10, 1);

foreach(var num in result) {
    Console.WriteLine(num);
}

/// <summary>
/// This is the answer for Question 1
/// </summary>
public class Question1
{
    /// <summary>
    /// Takes in 2 nums and print out the numbers that are even and in between them.
    /// Can be inclusive.
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public static int[] EvensOnly(int num1, int num2)
    {
        try
        {
            var smaller = num1 < num2 ? num1 : num2;
            var larger = num1 > num2 ? num1 : num2;

            // Edge case if num1  == num 2
            if (num1 == num2)
            {
                smaller = larger;
            }

            var result = new List<int>();
            while (smaller <= larger)
            {
                if (smaller % 2 == 0)
                {
                    result.Add(smaller);
                }
                smaller += 1;
            }
            return result.ToArray();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return [];
        }
    }
}

/// <summary>
/// This is the answer for Question 2
/// </summary>
public interface IVehicle {
    string Make { get; set; } 
    string Model { get; set; }
    int NumberOfWheels { get; set; }
    double Length { get; set; }
    double Weight { get; set; }
    int MaxPassengers { get; set; }
}

/// <summary>
/// Car object that inherits from vehicle (default values for weight, wheels, and passengers
/// </summary>
public class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int NumberOfWheels { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    public int MaxPassengers { get; set; }

    public Car(string make, string model, double length, int numberOfWheels = 4, double weight = 1500.0) {
        Make = make;
        Model = model;
        NumberOfWheels = numberOfWheels;
        Length = length;
        Weight = weight;
        MaxPassengers = 4;
    }
}

/// <summary>
/// Motorcycle object that inherits from vehicle (default values for weight, wheels, and passengers
/// </summary>
public class Motorcycle : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int NumberOfWheels { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    public int MaxPassengers { get; set; }

    public Motorcycle(string make, string model, double length, int numberOfWheels = 2, double weight = 750.0) {
        Make = make;
        Model = model;
        NumberOfWheels = numberOfWheels;
        Length = length;
        Weight = weight;
        MaxPassengers = 1;
    }
}

/// <summary>
/// Bus object that inherits from vehicle (default values for weight, wheels, and passengers
/// </summary>
public class Bus : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int NumberOfWheels { get; set; }
    public double Length { get; set; }
    public double Weight { get; set; }
    public int MaxPassengers { get; set; }

    public Bus(string make, string model, double length, int numberOfWheels = 4, double weight = 1500.0) {
        Make = make;
        Model = model;
        NumberOfWheels = numberOfWheels;
        Length = length;
        Weight = weight;
        MaxPassengers = 20;
    }
}

/// <summary>
/// Defines Garage parking spaces
/// </summary>
public class Garage {
    private int Spaces { get; set; }
    
    public Garage(int spaces) {
        Spaces = spaces;
    }

    public bool ParkVehicle(IVehicle vehicle) {
        if (Spaces > 0)
        {
            Spaces -= 1;
            return true;
        }

        return false;
    }
}

/// <summary>
/// Defines Lot parking space
/// </summary>
public class Lot {
    private int Spaces { get; set; }
    
    public Lot(int spaces) {
        Spaces = spaces;
    }

    public bool ParkVehicle(IVehicle vehicle) {
        if (Spaces > 0)
        {
            Spaces -= 1;
            return true;
        }

        return false;
    }
}

// I didn't get to the logic of parking, but I'd have that vehicle checks and other organization logic in an object that holds both garages and lots
public class Parking {
    private List<Lot> Lots { get; set; }
    private List<Garage> Garages { get; set; }

    public Parking(List<Lot> lots,  List<Garage> garages)
    {
        Lots = lots;
        Garages = garages;
    }
    
}

namespace VehicleHierarchy;

class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Console.WriteLine("Vehicle constructor is running");
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine(Year + " " + Brand + " has started.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        Console.WriteLine("Car constructor is running");
        NumberOfDoors = numberOfDoors;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Car: " + Brand + ", doors: " + NumberOfDoors);
    }
}

class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Console.WriteLine("Bus constructor is running");
        Capacity = capacity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Bus: " + Brand + ", capacity: " + Capacity + " passengers");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        Console.WriteLine("Motorcycle constructor is running");
        HasSidecar = hasSidecar;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Motorcycle: " + Brand + ", has sidecar: " + HasSidecar);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating a car:");
        Car car = new Car("Toyota", 2022, 4);

        Console.WriteLine();
        Console.WriteLine("Creating a bus:");
        Bus bus = new Bus("Mercedes", 2020, 45);

        Console.WriteLine();
        Console.WriteLine("Creating a motorcycle:");
        Motorcycle motorcycle = new Motorcycle("Honda", 2023, false);

        Console.WriteLine();
        Console.WriteLine("Starting all vehicles:");
        car.Start();
        bus.Start();
        motorcycle.Start();

        Console.WriteLine();
        Console.WriteLine("Vehicle details:");
        car.DisplayInfo();
        bus.DisplayInfo();
        motorcycle.DisplayInfo();
    }
}

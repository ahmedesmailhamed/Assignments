namespace OOP_1;

struct DeliveryAddress
{
    public string City;
    public string Street;
    public int BuildingNumber;

    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }

    public string GetFullAddress()
    {
        return $"{BuildingNumber}, {Street}, {City}";
    }
}

struct Shipment
{
    private string TrackingCode;
    private string Description;
    private decimal Weight;
    private decimal DeliveryFee;

    public DeliveryAddress Destination { get; set; }

    public Shipment(string trackingCode)
    {
        TrackingCode = trackingCode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    }

    public Shipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
    {
        TrackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "Unknown" : trackingCode;
        Description = string.IsNullOrWhiteSpace(description) ? "Unknown" : description;
        Weight = weight > 0 ? weight : 1;
        DeliveryFee = deliveryFee > 0 ? deliveryFee : 50;
        Destination = destination;
    }

    public string GetTrackingCode()
    {
        return TrackingCode;
    }

    public decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
            DeliveryFee = newFee;
    }

    public void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Delivery Fee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost}");
    }
}

struct DeliveryCenter
{
    private Shipment[] shipments;

    public DeliveryCenter()
    {
        shipments = new Shipment[10];
    }

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipments.Length)
                return shipments[index];

            return default;
        }

        set
        {
            if (index >= 0 && index < shipments.Length)
                shipments[index] = value;
        }
    }

    public Shipment this[string trackingCode]
    {
        get
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].GetTrackingCode() == trackingCode)
                    return shipments[i];
            }

            return default;
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (string.IsNullOrEmpty(shipments[i].GetTrackingCode()))
            {
                shipments[i] = shipment;
                return true;
            }
        }

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DeliveryCenter center = new DeliveryCenter();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter Shipment {i + 1}");

            Console.Write("Tracking Code: ");
            string trackingCode = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal deliveryFee = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Street: ");
            string street = Console.ReadLine();

            Console.Write("Building Number: ");
            int buildingNumber = int.Parse(Console.ReadLine());

            DeliveryAddress address =
                new DeliveryAddress(city, street, buildingNumber);

            Shipment shipment =
                new Shipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    address
                );

            center.AddShipment(shipment);

            Console.WriteLine();
        }

        Console.WriteLine("========== Shipments ==========");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Shipment {i + 1}:");
            center[i].PrintShipment();
            Console.WriteLine();
        }

        Console.Write("Enter tracking code: ");
        string searchCode = Console.ReadLine();

        Shipment foundShipment = center[searchCode];

        if (!string.IsNullOrEmpty(foundShipment.GetTrackingCode()))
        {
            foundShipment.PrintShipment();
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }

        Console.WriteLine();
        Console.WriteLine("========== Address Copy ==========");

        DeliveryAddress address1 =
            new DeliveryAddress("Cairo", "Nasr City", 10);

        DeliveryAddress address2 = address1;

        address2.Street = "New Street";
        address2.BuildingNumber = 20;

        Console.WriteLine("Original:");
        Console.WriteLine(address1.GetFullAddress());

        Console.WriteLine("Copy:");
        Console.WriteLine(address2.GetFullAddress());
    }
}
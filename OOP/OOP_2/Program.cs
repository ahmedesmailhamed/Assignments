namespace OOP_2;

class Program
{
    static void Main(string[] args)
    {
        #region Part 02

        // Create Delivery Center
        Console.Write("Enter Center Name: ");
        string centerName = Console.ReadLine()!;

        DeliveryCenter center = new DeliveryCenter(centerName);


        // ==========================================
        // Standard Shipment
        // ==========================================

        Console.WriteLine("\n--- Standard Shipment ---");

        Console.Write("Tracking Code: ");
        string trackingCode1 = Console.ReadLine()!;

        Console.Write("Description: ");
        string description1 = Console.ReadLine()!;

        Console.Write("Weight: ");
        decimal weight1 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Delivery Fee: ");
        decimal deliveryFee1 = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Destination:");

        Console.Write("City: ");
        string city1 = Console.ReadLine()!;

        Console.Write("Street: ");
        string street1 = Console.ReadLine()!;

        Console.Write("Building Number: ");
        int buildingNumber1 = int.Parse(Console.ReadLine()!);

        DeliveryAddress address1 =
            new DeliveryAddress(city1, street1, buildingNumber1);

        StandardShipment standardShipment =
            new StandardShipment(
                trackingCode1,
                description1,
                weight1,
                deliveryFee1,
                address1
            );


        // ==========================================
        // Express Shipment
        // ==========================================

        Console.WriteLine("\n--- Express Shipment ---");

        Console.Write("Tracking Code: ");
        string trackingCode2 = Console.ReadLine()!;

        Console.Write("Description: ");
        string description2 = Console.ReadLine()!;

        Console.Write("Weight: ");
        decimal weight2 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Delivery Fee: ");
        decimal deliveryFee2 = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Destination:");

        Console.Write("City: ");
        string city2 = Console.ReadLine()!;

        Console.Write("Street: ");
        string street2 = Console.ReadLine()!;

        Console.Write("Building Number: ");
        int buildingNumber2 = int.Parse(Console.ReadLine()!);

        Console.Write("Extra Fee: ");
        decimal extraFee = decimal.Parse(Console.ReadLine()!);

        DeliveryAddress address2 =
            new DeliveryAddress(city2, street2, buildingNumber2);

        ExpressShipment expressShipment =
            new ExpressShipment(
                trackingCode2,
                description2,
                weight2,
                deliveryFee2,
                address2,
                extraFee
            );


        // ==========================================
        // International Shipment
        // ==========================================

        Console.WriteLine("\n--- International Shipment ---");

        Console.Write("Tracking Code: ");
        string trackingCode3 = Console.ReadLine()!;

        Console.Write("Description: ");
        string description3 = Console.ReadLine()!;

        Console.Write("Weight: ");
        decimal weight3 = decimal.Parse(Console.ReadLine()!);

        Console.Write("Delivery Fee: ");
        decimal deliveryFee3 = decimal.Parse(Console.ReadLine()!);

        Console.WriteLine("Destination:");

        Console.Write("City: ");
        string city3 = Console.ReadLine()!;

        Console.Write("Street: ");
        string street3 = Console.ReadLine()!;

        Console.Write("Building Number: ");
        int buildingNumber3 = int.Parse(Console.ReadLine()!);

        Console.Write("Destination Country: ");
        string country = Console.ReadLine()!;

        Console.Write("Customs Fee: ");
        decimal customsFee = decimal.Parse(Console.ReadLine()!);

        DeliveryAddress address3 =
            new DeliveryAddress(city3, street3, buildingNumber3);

        InternationalShipment internationalShipment =
            new InternationalShipment(
                trackingCode3,
                description3,
                weight3,
                deliveryFee3,
                address3,
                country,
                customsFee
            );


        // ==========================================
        // Add Shipments
        // ==========================================

        center.AddShipment(standardShipment);
        center.AddShipment(expressShipment);
        center.AddShipment(internationalShipment);


        // ==========================================
        // Print Shipments using Integer Indexer
        // ==========================================

        Console.WriteLine("\n========== All Shipments ==========");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\n--- Shipment {i + 1} ---");
            center[i]?.PrintShipment();
        }


        // ==========================================
        // Search using String Indexer
        // ==========================================

        Console.Write("\nEnter Tracking Code to Search: ");
        string searchCode = Console.ReadLine()!;

        Shipment? shipment = center[searchCode];

        if (shipment != null)
        {
            Console.WriteLine("\nShipment Found:");
            shipment.PrintShipment();
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }


        // ==========================================
        // Remove Shipment
        // ==========================================

        Console.Write("\nEnter Tracking Code to Remove: ");
        string removeCode = Console.ReadLine()!;

        if (center.RemoveShipment(removeCode))
        {
            Console.WriteLine("Shipment removed successfully.");
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }


        // ==========================================
        // Print Remaining Shipments
        // ==========================================

        Console.WriteLine("\n========== Remaining Shipments ==========");
        center.PrintAllShipments();


        // ==========================================
        // DeliveryAddress Copy Demonstration
        // ==========================================

        Console.WriteLine("\n========== DeliveryAddress Copy ==========");

        DeliveryAddress original =
            new DeliveryAddress("Cairo", "Nasr City", 10);

        DeliveryAddress copy = original;

        copy.City = "Giza";
        copy.BuildingNumber = 20;

        Console.WriteLine("Original Address:");
        Console.WriteLine(original.GetFullAddress());

        Console.WriteLine("\nCopied Address:");
        Console.WriteLine(copy.GetFullAddress());

        #endregion
    }
}


// ==================================================
// DeliveryAddress
// ==================================================

struct DeliveryAddress
{
    public string City { get; set; }
    public string Street { get; set; }
    public int BuildingNumber { get; set; }


    public DeliveryAddress(
        string city,
        string street,
        int buildingNumber)
    {
        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }


    public string GetFullAddress()
    {
        return $"{City}, {Street}, Building Number: {BuildingNumber}";
    }
}


// ==================================================
// Shipment
// ==================================================

class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;


    public string TrackingCode
    {
        get
        {
            return trackingCode;
        }
    }


    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                description = value;
            }
        }
    }


    public decimal Weight
    {
        get
        {
            return weight;
        }

        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }


    public decimal DeliveryFee
    {
        get
        {
            return deliveryFee;
        }

        private set
        {
            if (value > 0)
            {
                deliveryFee = value;
            }
        }
    }


    public DeliveryAddress Destination { get; set; }


    public virtual decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5);
        }
    }


    // Constructor 1
    public Shipment(string trackingCode)
    {
        if (string.IsNullOrWhiteSpace(trackingCode))
        {
            throw new ArgumentException(
                "Tracking code cannot be empty.");
        }

        this.trackingCode = trackingCode;

        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;

        Destination =
            new DeliveryAddress(
                "Unknown",
                "Unknown",
                0
            );
    }


    // Constructor 2
    public Shipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
    {
        if (string.IsNullOrWhiteSpace(trackingCode))
        {
            throw new ArgumentException(
                "Tracking code cannot be empty.");
        }

        this.trackingCode = trackingCode;

        this.description = "Unknown";
        this.weight = 1;
        this.deliveryFee = 50;

        Description = description;
        Weight = weight;
        DeliveryFee = deliveryFee;

        Destination = destination;
    }


    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }
    }


    public virtual void PrintShipment()
    {
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"Delivery Fee: {DeliveryFee}");
        Console.WriteLine(
            $"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost}");
    }
}


// ==================================================
// StandardShipment
// ==================================================

class StandardShipment : Shipment
{
    public StandardShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination)
        : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination)
    {
    }
}


// ==================================================
// ExpressShipment
// ==================================================

class ExpressShipment : Shipment
{
    private decimal extraFee;


    public decimal ExtraFee
    {
        get
        {
            return extraFee;
        }

        set
        {
            if (value >= 0)
            {
                extraFee = value;
            }
        }
    }


    public ExpressShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        decimal extraFee)
        : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination)
    {
        ExtraFee = extraFee;
    }


    public override decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5) + ExtraFee;
        }
    }


    public override void PrintShipment()
    {
        base.PrintShipment();
        Console.WriteLine($"Extra Fee: {ExtraFee}");
    }
}


// ==================================================
// InternationalShipment
// ==================================================

class InternationalShipment : Shipment
{
    private string destinationCountry;
    private decimal customsFee;


    public string DestinationCountry
    {
        get
        {
            return destinationCountry;
        }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                destinationCountry = value;
            }
        }
    }


    public decimal CustomsFee
    {
        get
        {
            return customsFee;
        }

        set
        {
            if (value >= 0)
            {
                customsFee = value;
            }
        }
    }


    public InternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry,
        decimal customsFee)
        : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }


    public override decimal EstimatedCost
    {
        get
        {
            return DeliveryFee + (Weight * 5) + CustomsFee;
        }
    }


    public override void PrintShipment()
    {
        base.PrintShipment();
        Console.WriteLine(
            $"Destination Country: {DestinationCountry}");
        Console.WriteLine($"Customs Fee: {CustomsFee}");
    }
}


// ==================================================
// DeliveryCenter
// ==================================================

class DeliveryCenter
{
    public string CenterName { get; set; }

    private Shipment[] shipments;

    private int shipmentCount;


    public DeliveryCenter(string centerName)
    {
        CenterName = centerName;

        // Assignment 02: up to 20 shipments
        shipments = new Shipment[20];

        shipmentCount = 0;
    }


    // Integer Indexer
    public Shipment? this[int index]
    {
        get
        {
            if (index >= 0 && index < shipmentCount)
            {
                return shipments[index];
            }

            return null;
        }

        set
        {
            if (index >= 0 && index < 20)
            {
                shipments[index] = value!;
            }
        }
    }


    // String Indexer
    public Shipment? this[string trackingCode]
    {
        get
        {
            for (int i = 0; i < shipmentCount; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    return shipments[i];
                }
            }

            return null;
        }
    }


    // Add Shipment
    public bool AddShipment(Shipment shipment)
    {
        if (shipmentCount >= 20)
        {
            return false;
        }

        shipments[shipmentCount] = shipment;
        shipmentCount++;

        return true;
    }


    // Remove Shipment
    public bool RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < shipmentCount; i++)
        {
            if (shipments[i].TrackingCode == trackingCode)
            {
                for (int j = i; j < shipmentCount - 1; j++)
                {
                    shipments[j] = shipments[j + 1];
                }

                shipments[shipmentCount - 1] = null!;
                shipmentCount--;

                return true;
            }
        }

        return false;
    }


    // Print All Shipments
    public void PrintAllShipments()
    {
        for (int i = 0; i < shipmentCount; i++)
        {
            Console.WriteLine($"\n--- Shipment {i + 1} ---");
            shipments[i].PrintShipment();
        }
    }
}
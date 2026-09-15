namespace OOP_3;

class Program
{
    static void Main(string[] args)
    {
        Driver driver = new Driver("Ahmed Mohamed");

        DeliveryCenter center = new DeliveryCenter("Main Center");
        center.Driver = driver;

        DeliveryAddress address1 = new DeliveryAddress("Cairo", "Nasr City", 10);
        DeliveryAddress address2 = new DeliveryAddress("Giza", "Dokki", 20);
        DeliveryAddress address3 = new DeliveryAddress("Cairo", "Maadi", 30);

        StandardShipment standard = new StandardShipment(
            "SH001", "Laptop", 3, 80, address1);

        ExpressShipment express = new ExpressShipment(
            "SH002", "Mobile Phone", 2, 60, address2, 30);

        InternationalShipment international = new InternationalShipment(
            "SH003", "Television", 8, 120, address3, "Germany", 100);

        center.AddShipment(standard);
        center.AddShipment(express);
        center.AddShipment(international);

        Console.WriteLine("==========================================");
        Console.WriteLine("Delivery Center");
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine($"Driver : {center.Driver.Name}");
        Console.WriteLine();

        center.PrintAllShipments();

        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("Printing Using DeliveryHelper...");
        Console.WriteLine();

        DeliveryHelper.PrintShipmentDetails(standard);
        DeliveryHelper.PrintShipmentDetails(express);
        DeliveryHelper.PrintShipmentDetails(international);

        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("Updating Weight...");
        Console.WriteLine();
        Console.WriteLine($"Original Weight : {standard.Weight} KG");

        standard.UpdateWeight(5);
        Console.WriteLine($"Updated Weight : {standard.Weight} KG");

        standard.UpdateWeight(5, 0.5m);
        Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("Printing Using Shipment[]...");
        Console.WriteLine();

        Shipment[] shipments = { standard, express, international };

        foreach (Shipment shipment in shipments)
        {
            shipment.PrintShipment();
            Console.WriteLine();
        }

        CompletedShipment completed = new CompletedShipment(
            "SH004", "Package", 4, 70, address1);

        PriorityInternationalShipment priority =
            new PriorityInternationalShipment(
                "SH005", "Computer", 6, 150, address3, "USA", 80);

        Console.WriteLine(priority.GenerateCustomsReport());
    }
}

struct DeliveryAddress
{
    public string City { get; set; }
    public string Street { get; set; }
    public int BuildingNumber { get; set; }

    public DeliveryAddress(string city, string street, int buildingNumber)
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

class Driver
{
    public string Name { get; set; }

    public Driver(string name)
    {
        Name = name;
    }
}

class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;

    public string TrackingCode
    {
        get { return trackingCode; }
    }

    public string Description
    {
        get { return description; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    public decimal Weight
    {
        get { return weight; }
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    public decimal DeliveryFee
    {
        get { return deliveryFee; }
        private set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    public DeliveryAddress Destination { get; set; }

    public virtual decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5); }
    }

    public Shipment(string trackingCode)
    {
        if (string.IsNullOrWhiteSpace(trackingCode))
            throw new ArgumentException("Invalid tracking code");

        trackingCode = trackingCode;
        this.trackingCode = trackingCode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = new DeliveryAddress("Unknown", "Unknown", 0);
    }

    public Shipment(string trackingCode, string description, decimal weight,
        decimal deliveryFee, DeliveryAddress destination)
    {
        if (string.IsNullOrWhiteSpace(trackingCode))
            throw new ArgumentException("Invalid tracking code");

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
            DeliveryFee = newFee;
    }

    public void UpdateWeight(decimal newWeight)
    {
        if (newWeight > 0)
            Weight = newWeight;
    }

    public void UpdateWeight(decimal newWeight, decimal packingWeight)
    {
        if (newWeight > 0 && packingWeight >= 0)
            Weight = newWeight + packingWeight;
    }

    public virtual void PrintShipment()
    {
        Console.WriteLine("Standard Shipment");
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Description   : {Description}");
        Console.WriteLine($"Weight        : {Weight} KG");
        Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    }
}

class StandardShipment : Shipment
{
    public StandardShipment(string trackingCode, string description,
        decimal weight, decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }

    public override void PrintShipment()
    {
        Console.WriteLine("Standard Shipment");
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Description   : {Description}");
        Console.WriteLine($"Weight        : {Weight} KG");
        Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    }
}

class ExpressShipment : Shipment
{
    private decimal extraFee;

    public decimal ExtraFee
    {
        get { return extraFee; }
        set
        {
            if (value >= 0)
                extraFee = value;
        }
    }

    public ExpressShipment(string trackingCode, string description,
        decimal weight, decimal deliveryFee, DeliveryAddress destination,
        decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        ExtraFee = extraFee;
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5) + ExtraFee; }
    }

    public override void PrintShipment()
    {
        Console.WriteLine("Express Shipment");
        Console.WriteLine($"Tracking Code : {TrackingCode}");
        Console.WriteLine($"Description   : {Description}");
        Console.WriteLine($"Weight        : {Weight} KG");
        Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
        Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    }
}

class InternationalShipment : Shipment
{
    private string destinationCountry;
    private decimal customsFee;

    public string DestinationCountry
    {
        get { return destinationCountry; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                destinationCountry = value;
        }
    }

    public decimal CustomsFee
    {
        get { return customsFee; }
        set
        {
            if (value >= 0)
                customsFee = value;
        }
    }

    public InternationalShipment(string trackingCode, string description,
        decimal weight, decimal deliveryFee, DeliveryAddress destination,
        string destinationCountry, decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5) + CustomsFee; }
    }

    public virtual string GenerateCustomsReport()
    {
        return $"Customs Report for {TrackingCode}: {DestinationCountry}";
    }

    public override void PrintShipment()
    {
        Console.WriteLine("International Shipment");
        Console.WriteLine($"Tracking Code        : {TrackingCode}");
        Console.WriteLine($"Description           : {Description}");
        Console.WriteLine($"Weight                : {Weight} KG");
        Console.WriteLine($"Delivery Fee         : {DeliveryFee} EGP");
        Console.WriteLine($"Destination Country   : {DestinationCountry}");
        Console.WriteLine($"Customs Fee           : {CustomsFee} EGP");
        Console.WriteLine($"Estimated Cost        : {EstimatedCost} EGP");
    }
}

class PriorityInternationalShipment : InternationalShipment
{
    public PriorityInternationalShipment(string trackingCode, string description,
        decimal weight, decimal deliveryFee, DeliveryAddress destination,
        string destinationCountry, decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination,
            destinationCountry, customsFee)
    {
    }

    public sealed override string GenerateCustomsReport()
    {
        return $"Priority Customs Report for {TrackingCode}: {DestinationCountry}";
    }
}

sealed class CompletedShipment : Shipment
{
    public CompletedShipment(string trackingCode, string description,
        decimal weight, decimal deliveryFee, DeliveryAddress destination)
        : base(trackingCode, description, weight, deliveryFee, destination)
    {
    }
}

static class DeliveryHelper
{
    public static void PrintShipmentDetails(Shipment shipment)
    {
        shipment.PrintShipment();
    }
}

class DeliveryCenter
{
    public string CenterName { get; set; }
    public Driver Driver { get; set; }

    private Shipment[] shipments;
    private int shipmentCount;

    public DeliveryCenter(string centerName)
    {
        CenterName = centerName;
        shipments = new Shipment[20];
        shipmentCount = 0;
    }

    public Shipment this[int index]
    {
        get
        {
            if (index >= 0 && index < shipmentCount)
                return shipments[index];

            return null;
        }
        set
        {
            if (index >= 0 && index < 20)
                shipments[index] = value;
        }
    }

    public Shipment this[string trackingCode]
    {
        get
        {
            for (int i = 0; i < shipmentCount; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                    return shipments[i];
            }

            return null;
        }
    }

    public bool AddShipment(Shipment shipment)
    {
        if (shipmentCount >= 20)
            return false;

        shipments[shipmentCount] = shipment;
        shipmentCount++;
        return true;
    }

    public bool RemoveShipment(string trackingCode)
    {
        for (int i = 0; i < shipmentCount; i++)
        {
            if (shipments[i].TrackingCode == trackingCode)
            {
                for (int j = i; j < shipmentCount - 1; j++)
                    shipments[j] = shipments[j + 1];

                shipments[shipmentCount - 1] = null;
                shipmentCount--;

                return true;
            }
        }

        return false;
    }

    public void PrintAllShipments()
    {
        for (int i = 0; i < shipmentCount; i++)
        {
            shipments[i].PrintShipment();
            Console.WriteLine();
        }
    }
}
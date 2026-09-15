partial class Shipment
{
    private string trackingCode;
    private string description;
    private decimal weight;
    private decimal deliveryFee;

    public static int TotalShipmentsCreated;

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
        get { return DeliveryFee + Weight * 5; }
    }

    static Shipment()
    {
        TotalShipmentsCreated = 0;
        Console.WriteLine("Shipment System Initialized");
    }

    public Shipment(string trackingCode)
    {
        if (string.IsNullOrWhiteSpace(trackingCode))
            throw new ArgumentException("Invalid tracking code");

        this.trackingCode = trackingCode;
        Description = "Unknown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = new DeliveryAddress("Unknown", "Unknown", 0);

        TotalShipmentsCreated++;
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

        TotalShipmentsCreated++;
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

    public static int GetTotalShipmentsCreated()
    {
        return TotalShipmentsCreated;
    }

    public Shipment CopyShipment()
    {
        return new Shipment(
            TrackingCode,
            Description,
            Weight,
            DeliveryFee,
            new DeliveryAddress(
                Destination.City,
                Destination.Street,
                Destination.BuildingNumber));
    }

    public Shipment ShallowCopy()
    {
        return (Shipment)MemberwiseClone();
    }

    public Shipment DeepCopy()
    {
        Shipment copy = new Shipment(
            TrackingCode,
            Description,
            Weight,
            DeliveryFee,
            new DeliveryAddress(
                Destination.City,
                Destination.Street,
                Destination.BuildingNumber));

        copy.UpdateTrackingStatus(GetTrackingStatus());

        return copy;
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
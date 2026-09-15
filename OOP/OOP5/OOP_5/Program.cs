namespace OOP_5;

class Program
{
    static void Main(string[] args)
    {
        DeliveryUtilities.PrintSystemTitle();

        Console.WriteLine("Creating Shipments...");
        DeliveryUtilities.PrintSeparator();

        StandardShipment standard = new StandardShipment(
            "SH001", "Laptop", 3, 80,
            new DeliveryAddress("Cairo", "Nasr City", 10));

        ExpressShipment express = new ExpressShipment(
            "SH002", "Mobile Phone", 2, 60,
            new DeliveryAddress("Giza", "Dokki", 20), 30);

        InternationalShipment international = new InternationalShipment(
            "SH003", "Television", 8, 120,
            new DeliveryAddress("Cairo", "Maadi", 30),
            "Germany", 100);

        standard.UpdateTrackingStatus("In Transit");
        express.UpdateTrackingStatus("Out For Delivery");
        international.UpdateTrackingStatus("Delivered");

        Console.WriteLine("Standard Shipment Created");
        Console.WriteLine("Express Shipment Created");
        Console.WriteLine("International Shipment Created");

        Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Object Copying");
        DeliveryUtilities.PrintSeparator();

        Shipment shipment1 = standard;
        Shipment shipment2 = shipment1;

        Console.WriteLine($"Original Shipment : {shipment1.TrackingCode}");
        Console.WriteLine($"Assigned Shipment : {shipment2.TrackingCode}");
        Console.WriteLine($"Same Object : {ReferenceEquals(shipment1, shipment2)}");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Shallow Copy");
        DeliveryUtilities.PrintSeparator();

        Shipment shallow = shipment1.ShallowCopy();

        Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
        Console.WriteLine($"Copied Shipment Address : {shallow.Destination.City}");

        Console.WriteLine("Changing copied shipment address...");
        shallow.Destination.City = "Giza";

        Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
        Console.WriteLine($"Copied Shipment Address : {shallow.Destination.City}");
        Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, shallow.Destination)}");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Deep Copy");
        DeliveryUtilities.PrintSeparator();

        shipment1.Destination.City = "Cairo";

        Shipment deep = shipment1.DeepCopy();

        Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
        Console.WriteLine($"Copied Shipment Address : {deep.Destination.City}");

        Console.WriteLine("Changing copied shipment address...");
        deep.Destination.City = "Giza";

        Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
        Console.WriteLine($"Copied Shipment Address : {deep.Destination.City}");
        Console.WriteLine($"Same DeliveryAddress Object : {ReferenceEquals(shipment1.Destination, deep.Destination)}");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Extension Methods");
        DeliveryUtilities.PrintSeparator();

        Console.WriteLine(standard.GetSummary());
        Console.WriteLine(express.GetSummary());
        Console.WriteLine(international.GetSummary());

        Console.WriteLine($"SH001 Is Delivered : {standard.IsDelivered()}");
        Console.WriteLine($"SH003 Is Delivered : {international.IsDelivered()}");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Tracking Status");
        DeliveryUtilities.PrintSeparator();

        express.UpdateTrackingStatus("Out For Delivery");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Static Utilities");
        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Delivery Center");
        Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

        DeliveryUtilities.PrintSeparator();

        Console.WriteLine("Partial Method");
        DeliveryUtilities.PrintSeparator();

        international.UpdateTrackingStatus("Delivered");

        Shipment[] shipments = { standard, express, international };

        foreach (Shipment shipment in shipments)
        {
            shipment.PrintShipment();
            Console.WriteLine();
        }

        CompletedShipment completed = new CompletedShipment(
            "SH004", "Package", 4, 70,
            new DeliveryAddress("Cairo", "Heliopolis", 15));

        PriorityInternationalShipment priority =
            new PriorityInternationalShipment(
                "SH005", "Computer", 6, 150,
                new DeliveryAddress("Cairo", "Maadi", 20),
                "USA", 80);

        Console.WriteLine(priority.GenerateCustomsReport());

        Console.WriteLine();
        Console.WriteLine("Assignment Completed");
    }
}
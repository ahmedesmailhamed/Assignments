static class ShipmentExtensions
{
    public static string GetSummary(this Shipment shipment)
    {
        string type = shipment.GetType().Name.Replace("Shipment", "");

        return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {shipment.GetTrackingStatus()}";
    }

    public static bool IsDelivered(this Shipment shipment)
    {
        return shipment.GetTrackingStatus() == "Delivered";
    }
}
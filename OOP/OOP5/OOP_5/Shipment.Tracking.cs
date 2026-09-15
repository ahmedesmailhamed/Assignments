partial class Shipment
{
    private string trackingStatus = "Pending";

    public string GetTrackingStatus()
    {
        return trackingStatus;
    }

    public void UpdateTrackingStatus(string newStatus)
    {
        if (!string.IsNullOrWhiteSpace(newStatus))
        {
            trackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
    }

    partial void OnTrackingStatusChanged(string newStatus);
}
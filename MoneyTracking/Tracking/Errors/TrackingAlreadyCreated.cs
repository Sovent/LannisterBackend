using Common;

namespace MoneyTracking.Tracking.Errors
{
  public class TrackingAlreadyCreated : DomainError
  {
    public TrackingAlreadyCreated(TrackingId trackingId, string trackingName)
    {
      TrackingId = trackingId;
      TrackingName = trackingName;
    }

    public TrackingId TrackingId { get; }
    public string TrackingName { get; }
    public override string ToString() => $"Tracking {TrackingId} - {TrackingName} is already created";
  }
}
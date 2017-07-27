using Common;
using LanguageExt;

namespace MoneyTracking.Tracking
{
  public class Tracking : Entity<TrackingId>
  {
    public Tracking(Some<TrackingId> id) : base(id)
    {
    }

    public Unit Create(string trackingName)
    {
      return Unit.Default;
    }
  }
}
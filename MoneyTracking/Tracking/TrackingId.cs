using System;
using Common;

namespace MoneyTracking.Tracking
{
  public class TrackingId : EntityId
  {
    public TrackingId(Guid id) : base(id)
    {
    }

    public static TrackingId New => new TrackingId(Guid.NewGuid());    
  }
}
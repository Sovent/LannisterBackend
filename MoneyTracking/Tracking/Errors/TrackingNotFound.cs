using System;
using Common;

namespace MoneyTracking.Tracking.Errors
{
  public class TrackingNotFound : DomainError
  {
    public override string ToString()
    {
      throw new NotImplementedException();
    }
  }
}
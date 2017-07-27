using System;
using Common;

namespace MoneyTracking.User
{
  public class UserId : EntityId
  {
    public UserId(Guid id) : base(id)
    {
    }

    public static UserId New => new UserId(Guid.NewGuid());
  }
}
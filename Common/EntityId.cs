using System;

namespace Common
{
  public abstract class EntityId
  {
    protected EntityId(Guid id)
    {
      if (id == Guid.Empty) throw new ArgumentException("Id should not be empty");
      Id = id;
    }

    public Guid Id { get; }
  }
}

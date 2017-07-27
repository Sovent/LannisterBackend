using LanguageExt;

namespace Common
{
  public abstract class Entity<T> where T : EntityId
  {
    protected Entity(Some<T> id)
    {
      Id = id;
    }

    public T Id { get; }
  }
}
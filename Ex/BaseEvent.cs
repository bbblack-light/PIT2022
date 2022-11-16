namespace PIT2022.Ex;

public abstract class BaseEvent
{
    public virtual void Invoke()
    {
        Console.WriteLine("Base event");
    }
}

public abstract class BaseEvent<T> : BaseEvent
{
    public virtual void Invoke(T obj)
    {
        Console.WriteLine("Base event with generic");
    }
}
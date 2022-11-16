using System.Reflection;

namespace PIT2022.Ex;

public class EventManager
{
    public static EventManager Instance => _instance ??= new EventManager(); 
    private static EventManager? _instance;
    
    private Dictionary<Type, BaseEvent> _events = new Dictionary<Type, BaseEvent>()
    {
        {typeof(EnemyWasDeadEvent), new EnemyWasDeadEvent()},
        {typeof(GameOverEvent), new GameOverEvent()},
        {typeof(PlayerWasDeadEvent), new PlayerWasDeadEvent()}
    };

    public T ResolveEvent<T>() where T : BaseEvent
    {
        return (T)_events[typeof(T)];
    }
}
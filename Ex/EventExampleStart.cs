namespace PIT2022.Ex;

public class EventExampleStart
{
    public static void Start()
    {
        EventManager.Instance.ResolveEvent<PlayerWasDeadEvent>().Invoke(new Player("myEnemy"));
        EventManager.Instance.ResolveEvent<GameOverEvent>().Invoke();
    }
}
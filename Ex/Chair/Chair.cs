using System.Security.AccessControl;

namespace PIT2022.Ex.Chair;

public class Chair
{
    public readonly int MaxCount;

    public List<object> Humans
    {
        get => new List<object>(_humans);
    }

    private List<Human> _humans;

    public Chair(int maxCount)
    {
        MaxCount = maxCount;
        _humans = new List<Human>();
    }

    public void SitsDown(Human human)
    {
        if (human == null) throw new ArgumentException("human cannot be null");
        if (_humans.Count >= MaxCount)
        {
            Console.WriteLine("хруст");
            return;
        }

        _humans.Add(human);
    }

    public Human StandUp()
    {
        if (_humans.Count <= 0) return null;

        Human human = _humans[-1];
        _humans.Remove(human);
        return human;
    }
}
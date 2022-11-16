namespace PIT2022.Ex
{

    public class EnemyWasDeadEvent : BaseEvent<Enemy>
    {

    }

    public class Enemy
    {
        public string Name;

        public Enemy(string name)
        {
            this.Name = name;
        }
    }
}
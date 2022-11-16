namespace PIT2022.Ex
{

    public class PlayerWasDeadEvent : BaseEvent<Player>
    {
        public override void Invoke(Player obj)
        {
            base.Invoke(obj);
            Console.WriteLine("aaaaaaaaaaaa");
        }
    }

    public class Player
    {
        public string Username;

        public Player(string username)
        {
            Username = username;
        }
    }
}
namespace PIT2022.Ex
{

    public class Human
    {
        public readonly string Name;

        public Human(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
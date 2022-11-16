namespace PIT2022.Ex.GenericRockets
{

    public abstract class PetrolRocket : IRocket
    {
        public virtual void TakeOf()
        {
            Console.WriteLine("Petrol rocket take of");
        }

        public virtual void Land()
        {
            Console.WriteLine("Petrol rocket land");
        }
    }
}
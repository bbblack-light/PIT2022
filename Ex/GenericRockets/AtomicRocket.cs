namespace PIT2022.Ex.GenericRockets
{
    public abstract class AtomicRocket : IRocket
    {
        public virtual void TakeOf()
        {
            Console.WriteLine("Atomic rocket take of");
        }

        public virtual void Land()
        {
            Console.WriteLine("Atomic rocket land");
        }
    }
}
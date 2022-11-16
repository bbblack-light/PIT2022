namespace PIT2022.Ex.GenericRockets;

public class AT2 : AtomicRocket
{
    public override void TakeOf()
    {
        Console.WriteLine("AT2 take of");
    }

    public override void Land()
    {
        Console.WriteLine("AT2 land");
    }
}
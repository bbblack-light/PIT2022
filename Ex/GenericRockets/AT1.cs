namespace PIT2022.Ex.GenericRockets;

public class AT1 : AtomicRocket
{
    private int count;

    public AT1(int count)
    {
        this.count = count;
    }

    public override void TakeOf()
    {
        Console.WriteLine("AT1 take of");
        // for (int i = 0; i < count; i++)
        // {
        //     base.TakeOf();
        // }
        // Console.WriteLine("AT1 take of end");
    }

    public override void Land()
    {
        Console.WriteLine("AT1 land");
        // for (int i = 0; i < count; i++)
        // {
        //     base.Land();
        // }
        // Console.WriteLine("AT1 land end");
    }
}
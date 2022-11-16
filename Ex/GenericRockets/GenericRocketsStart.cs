namespace PIT2022.Ex.GenericRockets;

public class GenericRocketsStart
{
    public static void StartExample()
    {
        // Spaceport<IRocket> sp = new Spaceport<IRocket>();

        Baikanur sp = new Baikanur();
        sp.AddRocket(new AT1(2));
        sp.AddRocket(new AT2());
        sp.AddRocket(new AT1(2));
        sp.AddRocket(new AT2());
        sp.AddRocket(new AT1(2));
        // sp.AddRocket(new P1());
        // sp.AddRocket(new P2());
        
        sp.TestAllByType<AT1>();
    }

}
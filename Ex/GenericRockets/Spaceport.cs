namespace PIT2022.Ex.GenericRockets
{

    public class Spaceport<T> where T : IRocket
    {
        private List<T> _rockets = new List<T>();

        public void AddRocket(T r)
        {
            _rockets.Add(r);
        }

        public void TestAllByType<U>() where U : T
        {
            foreach (var rocket in _rockets)
            {
                if (rocket is U)
                {
                    try
                    {
                        rocket.TakeOf();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    try
                    {
                        rocket.Land();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
    }
}
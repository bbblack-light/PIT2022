namespace PIT2022.Ex.GenericRockets
{

    public class P2 : PetrolRocket
    {
        private Random r = new Random();
        private bool _isDestroyed;

        public override void TakeOf()
        {
            if (r.Next(0, 2) == 1)
            {
                _isDestroyed = true;
                throw new Exception("Rocket was destroyed");
            }

            base.TakeOf();
        }

        public override void Land()
        {
            if (_isDestroyed) throw new Exception("Rocket was destroyed when take of");
            base.Land();
        }
    }
}
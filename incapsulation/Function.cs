namespace PIT2022
{

    public class Function
    {
        private int A;
        private int B;
        private int C;

        public Function(int a, int b, int c)
        {
            A = a;
            B = b;
            if (c == 0) throw new ArgumentException("C cannot be a zero");
            C = c;
            X = (A + B) / C;
        }

        public float X { get; private set; }
        public float Y;

        public float Resolve()
        {
            ChangeX();
            Y = X * 5 + X;
            return Y;
        }

        private void ChangeX()
        {
            X++;
        }
    }
}
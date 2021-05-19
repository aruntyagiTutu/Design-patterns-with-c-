namespace Liskov_Substitution_Principle
{
    class Rectangle_Bad
    {
        public Rectangle_Bad(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public int Height
        {
            get;
            set;
        }
        public int Width
        {
            get;
            set;
        }
    }

    class Square_Bad : Rectangle_Bad
    {
        public Square_Bad() : base(0,0)
        {
        }

        public new int Height
        {
            set { base.Width = base.Height = value; }
        }

        public new int Width
        {
            set { base.Width = base.Height = value; }
        }

    }

    public class LSP_Client
    {
        static int Area(Rectangle_Bad r) => r.Width * r.Height;

        public static void Run()
        {
            Rectangle_Bad r = new Rectangle_Bad(4, 6);

            Rectangle_Bad s = new Square_Bad();
            s.Height = 5;

            // this will give wrong answer, which violates Liskov Substitution Principle;
            Area(s);
        }
    }
}
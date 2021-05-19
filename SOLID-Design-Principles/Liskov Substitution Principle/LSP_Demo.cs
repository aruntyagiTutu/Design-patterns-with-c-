namespace Liskov_Substitution_Principle
{
    class Rectangle
    {
        public Rectangle(int h, int w)
        {
            Height = h;
            Width = w;
        }
        public virtual int Height
        {
            get;
            set;
        }
        public virtual int Width
        {
            get;
            set;
        }
    }

    class Square : Rectangle
    {
        public Square() : base(0,0)
        {
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

    }

    public class LSP_Client_Demo
    {
        static int Area(Rectangle_Bad r) => r.Width * r.Height;

        public static void Run()
        {
            Rectangle r = new Rectangle(4, 6);
            
            Rectangle s = new Square();
            s.Width = 5;
        }
    }
}
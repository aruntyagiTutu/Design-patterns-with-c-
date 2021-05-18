using System.Collections.Generic;

namespace Open_Closed_Principle
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        White
    }

    public enum Size
    {
        small,

        medium,
        large
    }
    public class Product
    {
        public Color Color;
        public Size Size;
        public string Name;


        List<Product> products = new List<Product>();


        public Product(string Name, Color c, Size s)
        {
            this.Name = Name;
            Color = c;
            Size = s;
        }



    }
}
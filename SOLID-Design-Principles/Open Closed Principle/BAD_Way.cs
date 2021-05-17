using System.Collections.Generic;
using System.Linq;

namespace Open_Closed_Principle
{
    enum Size
    {
        small,
        Medium,
        large,
        extra_large
    }

    class Product
    {

        public int Id;
        public string Name;
        public string Color;
        public Size Size;

        public Product(int id, string name, string color, Size s)
        {
            Id = id;
            Name = name;
            this.Color = color;
            Size = s;
        }

    }

    class ProductFilters
    {
        List<Product> FilterByColor(List<Product> products, string color)
        {
           return products.Where(product => product.Color == color).ToList();
        }

         List<Product> FilterBySize(List<Product> products, Size s)
        {
           return products.Where(product => product.Size == s).ToList();
        }

        // as more filter asked we will add all of them here.. means we are changinging existing class to deliver newfeatures.
    }
}
using System;

namespace Open_Closed_Principle
{
    public class OCP_Client
    {
        public static void OCP_Steps_Run()
        {
            Product a = new Product("Shirt", Color.Red, Size.large);
            Product b = new Product("Watch", Color.Green, Size.medium);
            Product c = new Product("Something", Color.Red, Size.small);
            Product d = new Product("Food", Color.Blue, Size.medium);
            Product e = new Product("T-Shirts", Color.White, Size.large);

            Product[] products = new Product[] { a, b, c, d, e };

            ProductFilter pFilter = new ProductFilter();
            // filter by size
            foreach (var p in pFilter.Filter(products, new SizeSpecification(Size.small)))
                Console.WriteLine(p.Name);

            // filter by color
            foreach (var p in pFilter.Filter(products, new ColorSpecification(Color.Red)))
                Console.WriteLine(p.Name);


            var andSpec = new AndSpecification<Product>(new SizeSpecification(Size.large), new NameSpecification("Shirt"));
            //filter by name and size
            foreach (var p in pFilter.Filter(products, andSpec))
                Console.WriteLine(p.Name);

            var combinationSpec = new AndSpecification<Product>(andSpec, new ColorSpecification(Color.White));
            foreach (var p in pFilter.Filter(products, combinationSpec))
                Console.WriteLine(p.Name);
        }

    }
}
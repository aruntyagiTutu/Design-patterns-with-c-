using System;
using System.Collections.Generic;

namespace DSP_Bad
{
    class Product
    {
        public int Id;
        public string Name;
        public long Price;
    }

    class ProductService
    {
        public IList<Product> GetProducts()
        {
            // http call to external API 
            // or DB call to fetch data 
            // return data


            return new List<Product>();
        }
    }


    class ProductManager
    {
        ProductService productService;

        public ProductManager(ProductService service)
        {
            productService = service;
        }

        public IList<Product> GetProducts()
        {
            return productService.GetProducts();
        }
    }


    public class DIP_Client
    {
        public static void Run()
        {
            ProductManager pm = new ProductManager(new ProductService());
            
            
            pm.GetProducts();
        }
    }
}
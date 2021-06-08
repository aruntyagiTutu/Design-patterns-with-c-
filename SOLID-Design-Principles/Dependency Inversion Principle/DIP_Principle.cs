using System;
using System.Collections.Generic;


namespace DIP
{
    class Product
    {
        public int Id;
        public string Name;
        public long Price;
    }

    // abstraction
    interface IProductService
    {
        IList<Product> GetProducts();
    }
    class ProductService: IProductService
    {
        public IList<Product> GetProducts()
        {
            // http call to external API 
            // or DB call to fetch data 
            // return data


            return new List<Product>();
        }
    }

    class Mock_ProductService : IProductService
    {
        public IList<Product> GetProducts()
        {
            var mockData = new List<Product>();
            mockData.Add(new Product());
            mockData.Add(new Product());
            mockData.Add(new Product());
            mockData.Add(new Product());

            return mockData;
        }
    }


    class ProductManager
    {
        // use abstraction 
        IProductService productService;

        public ProductManager(IProductService service)
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
            ProductManager pm_with_mock_data = new ProductManager(new Mock_ProductService());


            pm.GetProducts();


        }
    }

}
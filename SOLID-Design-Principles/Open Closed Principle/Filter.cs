using System.Collections.Generic;

namespace Open_Closed_Principle
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach(var p in products)
                if(spec.IsSatisfied(p))
                    yield return p;
        }
    }
}
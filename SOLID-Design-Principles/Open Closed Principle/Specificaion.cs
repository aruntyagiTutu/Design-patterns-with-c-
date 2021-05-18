namespace Open_Closed_Principle
{
    // to force implementation for filters
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    } 

    // Concret specification
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }
        public bool IsSatisfied(Product p)
        {
            return p.Color == color;
        }
    }

    public class SizeSpecification: ISpecification<Product>
    {
        private Size size;
        public SizeSpecification(Size s)
        {
            size = s;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }

    public class NameSpecification: ISpecification<Product>
    {
         private string keyword;
        public NameSpecification(string keyword)
        {
            this.keyword = keyword;
        }

        public bool IsSatisfied(Product p)
        {
            return string.IsNullOrEmpty(p.Name) && p.Name.IndexOf(keyword) > -1;
        }
    }

    //Combination of specification

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first;
        private ISpecification<T> second;

        public AndSpecification(ISpecification<T> f, ISpecification<T> s)
        {
            first = f;
            second = s;
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

}
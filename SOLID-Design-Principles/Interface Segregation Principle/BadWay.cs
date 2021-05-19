namespace Interface_segregation_Principle
{
    interface IBigInterface
    {
        void Scan(Document d);
        void Print(Document d);
        void Fax(Document d);
    }

    // this is fine as this device having all feature which it can implement.
    class MultiFeaturePrinter : IBigInterface
    {
        public void Fax(Document d)
        {
            // implementation 
        }

        public void Print(Document d)
        {
            // implementation 
        }

        public void Scan(Document d)
        {
            // implementation 
        }
    }

// Violation of Interface segregation Principle as client is forced to implement methods/properties which it does not have.
    class ClassicPrinter : IBigInterface
    {
        public void Fax(Document d)
        {
            // can't implement
            throw new System.NotImplementedException();
        }

        public void Print(Document d)
        {
            // implementation 
        }

        public void Scan(Document d)
        {
            // can't implement
            throw new System.NotImplementedException();
        }
    }
}
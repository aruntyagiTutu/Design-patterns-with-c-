namespace Interface_segregation_Principle
{
    interface IPrint
    {
        void Print(Document d);
    }

    interface IScan
    {
        void Scan(Document d);

    }

    interface IFax
    {
        void Fax(Document d);

    }

    interface IMultiFeatureInterface : IScan, IPrint, IFax
    {

    }

    interface IMediumInterface: IScan, IPrint
    {

    }

    // this is fine as this device having all feature which it can implement.
    class Multi_FeaturePrinter : IMultiFeatureInterface
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

    class SomeWhatOldPrinter : IMediumInterface
    {
        public void Print(Document d)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new System.NotImplementedException();
        }
    }

    // No violation 
    class Classic_Printer : IPrint
    {

        public void Print(Document d)
        {
            // implementation 
        }

    }
}
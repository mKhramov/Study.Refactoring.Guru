namespace FactoryMethod
{
    public class ConcreteCreator2 : BaseCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}

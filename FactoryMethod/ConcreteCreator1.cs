namespace FactoryMethod
{
    public class ConcreteCreator1 : BaseCreator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}

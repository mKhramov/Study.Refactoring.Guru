namespace FactoryMethod
{
    public class MyProduct1Creator : BaseCreator
    {
        public override IProduct FactoryMethod()
        {
            return new MyProduct1();
        }
    }
}

namespace FactoryMethod
{
    public abstract class BaseCreator
    {
        public abstract IProduct FactoryMethod();
        
        public string SomeOperation()
        {            
            var product = FactoryMethod();         
            var result = "Creator: The same creator's code has just worked with " 
                + product.Operation();

            return result;
        }
    }
}

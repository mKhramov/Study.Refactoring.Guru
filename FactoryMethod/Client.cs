namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the MyProduct1.");
            ClientCode(new MyProduct1Creator());
        }
        
        public void ClientCode(BaseCreator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
        }
    }

}

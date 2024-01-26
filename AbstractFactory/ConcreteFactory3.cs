using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Каждая Конкретная Фабрика имеет соответствующую вариацию продукта.
    class ConcreteFactory3 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA3();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB3();
        }
    }

}

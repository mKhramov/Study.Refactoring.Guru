using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConcreteProductB3 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B3.";
        }

        // Продукт B2 может корректно работать только с Продуктом A3. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта А в качестве
        // аргумента.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B3 collaborating with the ({result})";
        }
    }
}

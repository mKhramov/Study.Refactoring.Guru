using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConcreteProductA3 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A3.";
        }
    }
}

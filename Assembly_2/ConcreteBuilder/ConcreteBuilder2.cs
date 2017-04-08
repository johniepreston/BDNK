using Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteBuilder
{
    public class ConcreteBuilder2 : IBuilder
    {
        private readonly Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("PartX");
        }

        public void BuildPartB()
        {
            _product.Add("PartY");
        }

        public void BuildPartC()
        {
            _product.Add("PartZ");
        }

        public Product GetResult()
        {
            return _product;
        }

    }
}

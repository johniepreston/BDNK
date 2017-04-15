using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcretePrototype
{
    public class Text : IPrototype
    {
        public String Value
        {
            get
            {
                return _value;
            }
        }

        public Text(String value)
        {
            _value = value.Clone().ToString();

        }

        public IPrototype Clone()
        {
            return new Text(Value);
        }

        private readonly String _value;

    }
}

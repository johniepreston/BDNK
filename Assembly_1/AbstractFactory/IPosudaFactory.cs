using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IPosudaFactory
    {
        IKnife CreateKnife();
        ISpoon CreateSpoon();

    }
}

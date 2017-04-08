using AbstractFactory;
using ConcreteFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPosudaFactory metalFactory = new MetalPosudaFactory();
            IPosudaFactory glassFactory = new GlassPosudaFactory();

            Tuple<IList<IKnife>, IList<ISpoon>> metalPosuda = Creator(metalFactory);
            Tuple<IList<IKnife>, IList<ISpoon>> glassPosuda = Creator(glassFactory);
        }

        static Tuple<IList<IKnife>, IList<ISpoon>> Creator(IPosudaFactory factory)
        {
            IList<IKnife> knifeList = new List<IKnife>();
            IList<ISpoon> spoonList = new List<ISpoon>();

            Tuple<IList<IKnife>, IList<ISpoon>> tuple = new Tuple<IList<IKnife>, IList<ISpoon>>(knifeList, spoonList);

            knifeList.Add(factory.CreateKnife());
            knifeList.Add(factory.CreateKnife());

            spoonList.Add(factory.CreateSpoon());
            spoonList.Add(factory.CreateSpoon());

            return tuple;
        }
    }
}

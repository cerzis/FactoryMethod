using FactoryMethod.Barocco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Loft
{
    public class LoftFurnitureCreator : FurnitureCreator
    {
        protected override IChair CreateChair()
        {
            return new LoftChair();
        }

        protected override ISofa CreateSofa()
        {
            return new LoftSofa();
        }

        protected override ITable CreateTable()
        {
            return new LoftTable();
        }
    }
}

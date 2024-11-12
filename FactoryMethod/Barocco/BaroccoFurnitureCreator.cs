using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Barocco
{
    public  class BaroccoFurnitureCreator : FurnitureCreator
    {
        protected override IChair CreateChair()
        {
            return new BaroccoChair();
        }

        protected override ISofa CreateSofa()
        {
            return new BaroccoSofa();
        }

        protected override ITable CreateTable()
        {
            return new BaroccoTable();
        }
    }
}

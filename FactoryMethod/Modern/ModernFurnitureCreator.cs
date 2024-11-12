using FactoryMethod.Loft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Modern
{
    public class ModernFurnitureCreator : FurnitureCreator
    {
        protected override IChair CreateChair()
        {
            return new ModernChair();
        }

        protected override ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        protected override ITable CreateTable()
        {
            return new ModernTable();
        }
    }
}

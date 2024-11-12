using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class FurnitureCreator
    {
        protected abstract IChair CreateChair();
        protected abstract ISofa CreateSofa();
        protected abstract ITable CreateTable();

        public string CreateChairFurniture()
        {
            Console.WriteLine("Производится Стул");
            var chair = CreateChair();
            return chair.Print();
        }
        public string CreateSofaFurniture()
        {
            Console.WriteLine("Производится Диван");
            var sofa = CreateSofa();
            return sofa.Print();
        }
        public string CreateTableFurniture()
        {
            Console.WriteLine("Производится Стол");
            var table = CreateTable();
            return table.Print();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Client
    {
        private FurnitureCreator _creator;
        public Client (FurnitureCreator creator)
        { _creator = creator; }

        public void Craft()
        {
         string chair = _creator.CreateChairFurniture();
            string sofa = _creator.CreateSofaFurniture();
            string table = _creator.CreateTableFurniture();7
        }


    }
}

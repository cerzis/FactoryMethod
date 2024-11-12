using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Loft
{
    public class LoftTable : ITable
    {
        public string Print()
        {
            string text = "Стол в стиле Лофт";
            return text;
        }
    }
}

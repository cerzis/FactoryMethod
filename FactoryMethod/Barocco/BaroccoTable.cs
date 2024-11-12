using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Barocco
{
    public class BaroccoTable : ITable
    {
        public string Print()
        {
            string text = "Стол в стиле Барокко";
            return text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Barocco
{
    public class BaroccoSofa : ISofa
    {
        public string Print()
        {
            string text = "Диван в стиле Барокко";
            return text;
        }
    }
}

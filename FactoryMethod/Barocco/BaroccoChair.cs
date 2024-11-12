using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Barocco
{
    public class BaroccoChair : IChair
    {
        public string Print()
        {
            string text = "Стул в стиле Барокко";
            return text;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Loft
{
    public class LoftSofa : ISofa
    {
        public string Print()
        {
            string text = "Диван в стиле Лофт";
            return text;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Modern
{
    public class ModernTable : ITable
    {
        public string Print()
        {
            string text = "Стол в стиле Модерн";
            return text;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Loft
{
    public class LoftChair : IChair
    {
        public string Print()
        {
            string text = "Стул в стиле Лофт";
            return text;
        }
    }
}

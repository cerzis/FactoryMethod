﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Modern
{
    public class ModernChair : IChair
    {
        public string Print()
        {
            string text = "Стул в стиле Модерн";
            return text;
        }
    }

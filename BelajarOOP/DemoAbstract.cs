﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
   abstract class DemoAbstract
    {
        public void Display()
        {
            Console.WriteLine("Perhitungan Selesai");
        }

        public abstract double Proccess();
    }
}


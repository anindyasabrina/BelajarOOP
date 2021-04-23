using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarOOP
{
    class Pembagian : DemoAbstract
    {
        public Pembagian(double a, double b)
        {
          A = a;
          B  = b;
        }

        public double A { get; private set; }
        public double B { get; private set; }

        public override double Proccess()
        {
          return A / B;
        }
    }
}

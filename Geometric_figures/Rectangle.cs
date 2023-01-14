using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
    class Rectangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }

        public override double GetS() => A * B;

        public override double GetP() => 2 * (A + B);
    }
}

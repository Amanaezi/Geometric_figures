using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
    class Triangle : Shape
    {
        public double A { get; set; }
        public double H { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override double GetS()
        {
            return 0.5 * A * H;
        }
        public override double GetP()
        {
            return A + B + C;
        }
    }
}

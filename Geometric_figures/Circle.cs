using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
    public class Circle : Shape
    {
        public double R { get; set; }

        public override double GetS()
        {
            return Math.PI * R * R;
        }
        public override double GetP()
        {
            return 2 * Math.PI * R;
        }
    
    }
}

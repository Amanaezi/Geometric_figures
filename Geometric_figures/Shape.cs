using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures
{
    public abstract class Shape
    {
        public abstract double GetS();
        public abstract double GetP();

        public void GetInf()
        {
            Console.WriteLine("S = ", GetS(), "P = ", GetP());
        }

        public override string ToString()
        {
            return $"P = {GetP()}; S = {GetS()}";
        }
    }
}

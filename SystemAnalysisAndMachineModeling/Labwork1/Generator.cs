using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork1
{
    public class Generator
    {
        public double R0 { get; }
        public double M { get; }
        public double A { get; }

        public Generator(double a, double m, double r0)
        {
            A = a;
            M = m;
            R0 = r0;
        }

        public IEnumerable<double> GetNext()
        {
            double prevR = R0;
            double curR;
            while (true)
            {
                curR = (A * prevR) % M;
                prevR = curR;
                yield return curR / M;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributions
{
    public static class Distribution
    {
        public static List<double> Uniform(IEnumerable<double> values, double a, double b)
        {
            List<double> list = new List<double>();

            foreach (double R in values)
            {
                list.Add(a + (b - a) * R);
            }

            return list;
        }

        public static List<double> Exponential(IEnumerable<double> values, double λ)
        {
            List<double> list = new List<double>();

            foreach (double R in values)
            {
                list.Add(-1 * Math.Log(R) / λ);
            }

            return list;
        }

        public static List<double> Triangular(IEnumerable<double> values, double a, double b)
        {
            List<double> list = new List<double>();
            double[] array = values.ToArray();

            for (int i = 0; i < array.Length; i += 2)
            {
                //if (array[i + 1] < array[i])
                {
                    list.Add(a + (b - a) * Math.Max(array[i], array[i + 1]));
                }
            }

            return list;
        }
    }
}
